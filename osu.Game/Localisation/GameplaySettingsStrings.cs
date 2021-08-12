// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class GameplaySettingsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.GameplaySettings";

        /// <summary>
        /// "Gameplay"
        /// </summary>
        public static LocalisableString GameplaySectionHeader => new TranslatableString(getKey(@"gameplay_section_header"), @"Gameplay");

        /// <summary>
        /// "General"
        /// </summary>
        public static LocalisableString GeneralHeader => new TranslatableString(getKey(@"general_header"), @"General");

        /// <summary>
        /// "Background dim"
        /// </summary>
        public static LocalisableString Dim => new TranslatableString(getKey(@"dim"), @"Background dim");

        /// <summary>
        /// "Background blur"
        /// </summary>
        public static LocalisableString Blur => new TranslatableString(getKey(@"blur"), @"Background blur");

        /// <summary>
        /// "Lighten playfield during breaks"
        /// </summary>
        public static LocalisableString LightenDuringBreaks => new TranslatableString(getKey(@"lighten_during_breaks"), @"Lighten playfield during breaks");

        /// <summary>
        /// "HUD overlay visibility mode"
        /// </summary>
        public static LocalisableString HUDVisibilityMode => new TranslatableString(getKey(@"hud_visibility_mode"), @"HUD overlay visibility mode");

        /// <summary>
        /// "Show difficulty graph on progress bar"
        /// </summary>
        public static LocalisableString ShowProgressGraph => new TranslatableString(getKey(@"show_progress_graph"), @"Show difficulty graph on progress bar");

        /// <summary>
        /// "Show health display even when you can't fail"
        /// </summary>
        public static LocalisableString ShowHealthDisplayWhenCantFail => new TranslatableString(getKey(@"show_health_display_when_cant_fail"), @"Show health display even when you can't fail");

        /// <summary>
        /// "Fade playfield to red when health is low"
        /// </summary>
        public static LocalisableString FadePlayfieldWhenHealthLow => new TranslatableString(getKey(@"fade_playfield_when_health_low"), @"Fade playfield to red when health is low");

        /// <summary>
        /// "Always show key overlay"
        /// </summary>
        public static LocalisableString KeyOverlay => new TranslatableString(getKey(@"key_overlay"), @"Always show key overlay");

        /// <summary>
        /// "Positional hitsounds"
        /// </summary>
        public static LocalisableString PositionalHitsounds => new TranslatableString(getKey(@"positional_hitsounds"), @"Positional hitsounds");

        /// <summary>
        /// "Always play first combo break sound"
        /// </summary>
        public static LocalisableString AlwaysPlayFirstComboBreak => new TranslatableString(getKey(@"always_play_first_combo_break"), @"Always play first combo break sound");

        /// <summary>
        /// "Score display mode"
        /// </summary>
        public static LocalisableString ScoreDisplayMode => new TranslatableString(getKey(@"score_display_mode"), @"Score display mode");

        /// <summary>
        /// "Disable Windows key during gameplay"
        /// </summary>
        public static LocalisableString DisableWinKey => new TranslatableString(getKey(@"disable_win_key"), @"Disable Windows key during gameplay");

        /// <summary>
        /// "Mods"
        /// </summary>
        public static LocalisableString ModsHeader => new TranslatableString(getKey(@"mods_header"), @"Mods");

        /// <summary>
        /// "Increase visibility of first object when visual impairment mods are enabled"
        /// </summary>
        public static LocalisableString IncreaseFirstObjectVisibility => new TranslatableString(getKey(@"increase_first_object_visibility"), @"Increase visibility of first object when visual impairment mods are enabled");

        private static string getKey(string key) => $"{prefix}:{key}";
    }
}
