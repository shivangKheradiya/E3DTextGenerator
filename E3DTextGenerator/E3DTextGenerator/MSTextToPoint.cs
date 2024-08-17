using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DTextGenerator
{
    public static class MSTextToPoint
    {
        public static string Text { get; set; } = "";
            //"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/*-+.`~!@#$%^&*()_+[]\\{}|;':\",./<>?";
        public static string FontName { get; set; } = "Arial";
        public static float TextSize { get; set; } = 250f;
        public static GraphicsUnit TextHeightUnits { get; set; } = GraphicsUnit.Millimeter;
        public static FontStyle FontStyle { get; set; } = FontStyle.Regular;
        public static List<List<byte>> PointTypesForSentense { get; set; } = new List<List<byte>>();
        public static float WidthFactor { get; set; } = 1f;
        public static bool isBold { get; set; } = false;
        public static bool isItalic { get; set; } = false;
        public static bool isStickthrough { get; set; } = false;
        public static bool isUnderlined { get; set; } = false;

        public static List<List<PointF>> GetGlyphPoints()
        {
            List<List<PointF>> result = new List<List<PointF>>();
            using (Font font = new Font(FontName, TextSize, FontStyle, TextHeightUnits))
            {
                using (Bitmap bitmap = new Bitmap(1, 1))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                        float xLocationForText = 0;

                        foreach (char character in Text)
                        {
                            List<PointF> glyphPoints = new List<PointF>();
                            List<byte> pointTypes = new List<byte>();

                            using (GraphicsPath graphicsPath = new GraphicsPath())
                            {
                                graphicsPath.AddString(character.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(xLocationForText, 0), StringFormat.GenericDefault);
                                try
                                {
                                    byte[] pointsTypeByte = graphicsPath.PathTypes;
                                    for (int i = 0; i < graphicsPath.PathPoints.Length; i++)
                                    {
                                        glyphPoints.Add(new PointF(graphicsPath.PathPoints[i].X, graphicsPath.PathPoints[i].Y));
                                        pointTypes.Add(pointsTypeByte[i]);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error: " + ex.Message);
                                    xLocationForText += TextSize * WidthFactor;
                                }
                                xLocationForText += graphicsPath.GetBounds().Width * WidthFactor;
                            }
                            result.Add(glyphPoints);
                            PointTypesForSentense.Add(pointTypes);
                            // SizeF sizeF = graphics.MeasureString(character.ToString(), font);
                            // xLocationForText += sizeF.Width * WidthFactor;
                        }
                    }
                }
            }
            return result;
        }

        public static void SetFontStyle()
        {
            if (isBold)
                FontStyle ^= FontStyle.Bold;
            if (isItalic)
                FontStyle ^= FontStyle.Italic;
            if (isUnderlined)
                FontStyle ^= FontStyle.Underline;
            if (isStickthrough)
                FontStyle ^= FontStyle.Strikeout;
        }
    }
}
