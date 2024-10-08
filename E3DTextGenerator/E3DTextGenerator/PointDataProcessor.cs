﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace E3DTextGenerator
{
    public class PointDataProcessor
    {
        public List<List<PointF>> GlyphPointsForSentence { get; set; }
        public string Text { get; set; }
        public List<List<byte>> PointsTypesForSentence { get; set; }
        List<byte> BytesSeparatorForLoop { get; set; } = new List<byte>();
        public List<CharacterData> CharacterDataList { get; set; } = new List<CharacterData>();
        public string ExtrusionInfoFilePath { get; set; } = Directory.GetCurrentDirectory() + @"\ExtrusionInfo.xml";
        public string FontName { get; set; }

        public PointDataProcessor() 
        {
            BytesSeparatorForLoop.Add(byte.Parse("129"));
            BytesSeparatorForLoop.Add(byte.Parse("131"));
            BytesSeparatorForLoop.Add(byte.Parse("161"));
            BytesSeparatorForLoop.Add(byte.Parse("163"));
        }

        public void CreateBoundaryData()
        {
            for (int i = 0; i < Text.Length; i++)
            {
                CharacterData characterData = new CharacterData();
                characterData.CharacterName = Text[i].ToString();
                characterData.PointsList = GlyphPointsForSentence[i];
                characterData.PointsTypeList = PointsTypesForSentence[i];
                List<PointF> Boundary = new List<PointF>();
                for (int j = 0; j < characterData.PointsList.Count; j++)
                {
                    bool isSeparator = BytesSeparatorForLoop.Contains(characterData.PointsTypeList[j]);
                    if (!isSeparator)
                    {
                        Boundary.Add(characterData.PointsList[j]);
                    }
                    else
                    {
                        Boundary.Add(characterData.PointsList[j]);
                        characterData.Boundaries.Add(Boundary);
                        Boundary = new List<PointF>();
                    }
                }
                if (Boundary.Count != 0)
                {
                    characterData.Boundaries.Add(Boundary);
                    Boundary = new List<PointF>();
                }
                CharacterDataList.Add(characterData);
            }
        }

        public void ReadNegativeExtrusionInfo()
        {
            XElement ExtrusionInfoXmlFile = XElement.Load(ExtrusionInfoFilePath);
            try
            {
                for (int i = 0; i < CharacterDataList.Count; i++)
                {
                    XElement FontElement = ExtrusionInfoXmlFile.Elements().FirstOrDefault(x => x.Attribute("FontName").Value == FontName);
                    XElement characterElement = FontElement.Elements().FirstOrDefault(x=> x.Attribute("Character").Value == CharacterDataList[i].CharacterName);
                    if (characterElement != null)
                        CharacterDataList[i].BoundariesNegativeExtrusions = characterElement.Attribute("NegativeExtrusions").Value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}
