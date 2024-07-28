using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3DTextGenerator
{
    public partial class E3DTextGeneratorForm : Form
    {
        private static DBListGenerator dBListGenerator = new DBListGenerator();
        private static PointDataProcessor pointDataProcessor = new PointDataProcessor();
        
        public E3DTextGeneratorForm()
        {
            InitializeComponent();
        }

        private void buClear_Click(object sender, EventArgs e)
        {
            tbE3DText.Clear();
            tbExtrusionLength.Clear();
            tbTextHeight.Clear();
            tbTextWidthFactor.Clear();
            chbBold.CheckState = CheckState.Unchecked;
            chbItalic.CheckState = CheckState.Unchecked;
            chbStricktrhough.CheckState = CheckState.Unchecked;
            chbUnderline.CheckState = CheckState.Unchecked;
        }

        private void buGenerate_Click(object sender, EventArgs e)
        {
            MSTextToPoint.isBold = chbBold.Checked;
            MSTextToPoint.isItalic = chbItalic.Checked;
            MSTextToPoint.isUnderlined = chbUnderline.Checked;
            MSTextToPoint.isStickthrough = chbStricktrhough.Checked;
            MSTextToPoint.SetFontStyle();

            MSTextToPoint.Text = tbE3DText.Text;
            MSTextToPoint.TextSize = float.Parse(tbTextHeight.Text);
            MSTextToPoint.FontName = cbFontName.Text;

            pointDataProcessor.GlyphPointsForSentence = MSTextToPoint.GetGlyphPoints();
            pointDataProcessor.Text = tbE3DText.Text;
            pointDataProcessor.PointsTypesForSentence = MSTextToPoint.PointTypesForSentense;
            pointDataProcessor.CreateBoundaryData();

            pointDataProcessor.FontName = MSTextToPoint.FontName;
            pointDataProcessor.ReadNegativeExtrusionInfo();

            dBListGenerator.CharacterDataList = pointDataProcessor.CharacterDataList;
            dBListGenerator.GlyphpointsTypesForSentence = MSTextToPoint.PointTypesForSentense;
            dBListGenerator.GenerateDbList();
            dBListGenerator.SaveDbList();
        }

        private void tbTextHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumericsAllowed(ref sender, ref e);
        }

        private void tbNumericsAllowed(ref object sender, ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbExtrusionLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumericsAllowed(ref sender, ref e);
        }
    }
}
