using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSimulator
{
    class Renderer
    {
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        private Dictionary<Flower, PictureBox> flowerLookup = new Dictionary<Flower, PictureBox>();
        private Dictionary<Bee, BeeControlBox> beeLookup = new Dictionary<Bee, BeeControlBox>();

        
        //b e e C o n t r o l = b e e L o o k u p[b e e];
        //b e e C o n t r o l.L o c a t i o n = b e e . L o c a t i o n ;




    }
}
