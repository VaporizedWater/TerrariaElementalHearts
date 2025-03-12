using Microsoft.Xna.Framework;
using System.Text;

namespace ElementalHeartsRevivedMod.lib {
    internal class EHR_Utility {

        /// <summary>
        /// Creates colored text for tooltips. Supports text with new line characters.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string CalculateColoredText(string message, Color color) {
            string[] strings = message.Split('\n');
            StringBuilder builder = new();
            for (int i = 0; i < strings.Length; i++) {
                if (i == strings.Length - 1) {
                    _ = builder.Append(FormatColor(strings[i], color));
                    break;
                }
                _ = builder.Append(FormatColor(strings[i], color)).Append('\n');
            }
            return builder.ToString();
        }

        internal enum TextGradientDirection {
            Vertical,
            Horizontal
        }

        // These two are old implementations and likely will not work
        ///// <summary>
        ///// Creates a gradient of colored text across an entire string based on two endpoint colors and a direction for the gradient.<br></br><br></br>
        ///// TextGradientDirection:<br></br>
        ///// <b>Vertical</b> - distributes the colors across new lines<br></br><b>Horizontal</b> - distributes colors across characters
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <param name="direction"></param>
        ///// <returns></returns>
        //public static string CalculateColoredText(string message, Color start, Color end, TextGradientDirection direction) {
        //    StringBuilder coloredOutputText = new();
        //    switch (direction) {
        //        case TextGradientDirection.Vertical:
        //            string[] lines = message.Split(Environment.NewLine);
        //            for (int i = 0; i < lines.Length; i++) {
        //                float progress = (float)i / Math.Max(1, lines.Length - 1);
        //                Color gradientColor = Color.Lerp(start, end, progress);
        //                _ = coloredOutputText.AppendLine(FormatColor(lines[i], gradientColor));
        //            }
        //            break;
        //        case TextGradientDirection.Horizontal:
        //            for (int i = 0; i < message.Length; i++) {
        //                float progress = (float)i / Math.Max(1, message.Length - 1);
        //                Color gradientColor = Color.Lerp(start, end, progress);
        //                _ = coloredOutputText.Append(FormatColor(message[i].ToString(), gradientColor));
        //            }
        //            break;
        //    }

        //    return coloredOutputText.ToString();
        //}

        ///// <summary>
        ///// Creates a gradient of colored text across an entire string based on two endpoint colors and a direction for the gradient.<br></br><br></br>
        ///// </summary>
        ///// <param name="message"></param>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <returns></returns>
        //public static string CalculateColoredText(string message, Color start, Color end) {
        //    StringBuilder coloredOutputText = new();

        //    string[] lines = message.Split(Environment.NewLine);

        //    foreach (string line in lines) {
        //        for (int i = 0; i < line.Length; i++) {
        //            float progress = (float)i / Math.Max(1, line.Length - 1);
        //            Color gradientColor = Color.Lerp(start, end, progress);
        //            _ = coloredOutputText.Append(FormatColor(line[i].ToString(), gradientColor));
        //        }
        //        _ = coloredOutputText.AppendLine();
        //    }

        //    return coloredOutputText.ToString();
        //}

        private static string FormatColor(string text, Color color) {
            string colorCode = $"{color.R:X2}{color.G:X2}{color.B:X2}";
            // Escape closing brackets within the text
            string escapedText = text.Replace("]", "][c/" + colorCode + ":]");
            return $"[c/{colorCode}:{escapedText}]";
        }
    }
}
