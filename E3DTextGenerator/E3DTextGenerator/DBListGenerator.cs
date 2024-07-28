using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DTextGenerator
{
    public class DBListGenerator
    {
        public List<CharacterData> CharacterDataList { get; set; } = new List<CharacterData>();
        public string DbListFilePath { get; set; } = @"C:\db\DBList.txt";
        public List<string> DbList { get; set; } = new List<string>();
        public List<List<byte>> GlyphpointsTypesForSentence { get; set; }
        public float ExtrusionLength { get; set; } = 100f;

        public void GenerateDbList()
        {
            for(int i=0; i < CharacterDataList.Count; i++)
            {
                GenerateElement("SBFR");
                for (int j = 0; j < CharacterDataList[i].Boundaries.Count; j++)
                {
                    bool isExtrusion = CharacterDataList[i].BoundariesNegativeExtrusions.Split(',').Contains(j.ToString());
                    if (!isExtrusion)
                    {
                        GenerateElement("PANE");
                        GeneratePLOOP();
                        GenerateElement("PAVE", i, j);
                    }
                    else
                    {
                        GenerateNXTR();
                        DbList.Add("BY D" + ExtrusionLength);
                        GenerateElement("LOOP");
                        GenerateElement("VERT", i, j);
                    }
                }
            }
        }

        public void GenerateElement(string ElementType)
        {
            DbList.Add("NEW " + ElementType);
        }

        public void GenerateElement(string ElementType, int CharIdx, int LoopIdx)
        {
            foreach (PointF point in CharacterDataList[CharIdx].Boundaries[LoopIdx])
            {
                GenerateElement(ElementType);
                DbList.Add("AT E" + Math.Round(point.X) + " N" + Math.Round(point.Y) + " U0");
            }
        }

        public void GeneratePLOOP()
        {
            GenerateElement("PLOO");
            DbList.Add("HEIGHT " + ExtrusionLength + " SJUS UTOP");
        }
        
        public void GenerateNXTR()
        {
            GenerateElement("NXTR");
            DbList.Add("HEIGHT " + ExtrusionLength);
        }

        public void SaveDbList()
        {
            using (FileStream fileStream = new FileStream(DbListFilePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (string line in DbList)
                    {
                        streamWriter.WriteLine(line);
                    }
                }
            }
        }
    }
}
