// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Rulesets.UI.Scrolling;
using osu.Game.Skinning;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Mania.Skinning.Legacy
{
    public partial class LegacyManiaComboCounter : LegacyComboCounter
    {
        [BackgroundDependencyLoader]
        private void load(ISkinSource skin)
        {
            DisplayedCountText.Anchor = Anchor.Centre;
            DisplayedCountText.Origin = Anchor.Centre;

            PopOutCountText.Anchor = Anchor.Centre;
            PopOutCountText.Origin = Anchor.Centre;
            PopOutCountText.Colour = skin.GetManiaSkinConfig<Color4>(LegacyManiaSkinConfigurationLookups.ComboBreakColour)?.Value ?? Color4.Red;
        }

        [Resolved]
        private IScrollingInfo scrollingInfo { get; set; } = null!;

        private IBindable<ScrollingDirection> direction = null!;

        protected override void LoadComplete()
        {
            base.LoadComplete();

            direction = scrollingInfo.Direction.GetBoundCopy();
            direction.BindValueChanged(_ => updateAnchor());

            // two schedules are required so that updateAnchor is executed in the next frame,
            // which is when the combo counter receives its Y position by the default layout in LegacyManiaSkinTransformer.
            Schedule(() => Schedule(updateAnchor));
        }

        private void updateAnchor()
        {
            // if the anchor isn't a vertical center, set top or bottom anchor based on scroll direction
            if (Anchor.HasFlag(Anchor.y1))
                return;

            Anchor &= ~(Anchor.y0 | Anchor.y2);
            Anchor |= direction.Value == ScrollingDirection.Up ? Anchor.y2 : Anchor.y0;

            // change the sign of the Y coordinate in line with the scrolling direction.
            // i.e. if the user changes direction from down to up, the anchor is changed from top to bottom, and the Y is flipped from positive to negative here.
            Y = Math.Abs(Y) * (direction.Value == ScrollingDirection.Up ? -1 : 1);
        }

        protected override void OnCountIncrement()
        {
            base.OnCountIncrement();

            PopOutCountText.Hide();
            DisplayedCountText.ScaleTo(new Vector2(1f, 1.4f))
                              .ScaleTo(new Vector2(1f), 300, Easing.Out)
                              .FadeIn(120);
        }

        protected override void OnCountChange()
        {
            base.OnCountChange();

            PopOutCountText.Hide();
            DisplayedCountText.ScaleTo(1f);
        }

        protected override void OnCountRolling()
        {
            if (DisplayedCount > 0)
            {
                PopOutCountText.Text = FormatCount(DisplayedCount);
                PopOutCountText.FadeTo(0.8f).FadeOut(200)
                               .ScaleTo(1f).ScaleTo(4f, 200);

                DisplayedCountText.FadeTo(0.5f, 300);
            }

            base.OnCountRolling();
        }
    }
}
