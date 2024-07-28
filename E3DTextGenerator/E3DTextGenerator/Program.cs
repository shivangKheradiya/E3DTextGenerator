using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DTextGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBListGenerator dBListGenerator = new DBListGenerator();
            PointDataProcessor pointDataProcessor = new PointDataProcessor();

            pointDataProcessor.GlyphPointsForSentence = MSTextToPoint.GetGlyphPoints();
            pointDataProcessor.Text = MSTextToPoint.Text;
            pointDataProcessor.PointsTypesForSentence = MSTextToPoint.PointTypesForSentense;
            pointDataProcessor.CreateBoundaryData();

            pointDataProcessor.FontName = MSTextToPoint.FontName;
            pointDataProcessor.ReadNegativeExtrusionInfo();

            dBListGenerator.CharacterDataList = pointDataProcessor.CharacterDataList;
            dBListGenerator.GlyphpointsTypesForSentence = MSTextToPoint.PointTypesForSentense;
            dBListGenerator.GenerateDbList();
            dBListGenerator.SaveDbList();
        }
    }
}
