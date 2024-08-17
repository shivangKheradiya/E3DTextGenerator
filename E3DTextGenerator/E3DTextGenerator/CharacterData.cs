using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DTextGenerator
{
    public class CharacterData
    {
        public string CharacterName { get; set; } = string.Empty;
        public List<PointF> PointsList { get; set; } = new List<PointF>();
        public List<byte> PointsTypeList { get; set; } = new List<byte>();
        public List<List<PointF>> Boundaries { get; set; } = new List<List<PointF>>();
        public List<bool> BoundariesType { get; set; } = new List<bool>();
        public string BoundariesNegativeExtrusions { get; set; } = string.Empty;
    }
}
