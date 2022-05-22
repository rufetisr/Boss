using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossProg
{
    class CV
    {
        public string Ixtisas { get; set; }
        public string OxuduguMekteb { get; set; }
        public int UniQebulBali { get; set; }
        public string Bacariqlar { get; set; }
        public string Companies { get; set; }
        public DateTime StartWorkTime { get; set; }
        public DateTime StopWorkTime { get; set; }
        public string BildiyiDiller { get; set; }
        public string FerqlenmeDiplomu { get; set; }
        public string GitLink { get; set; }
        public string Linkedln { get; set; }

        public override string ToString()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            return $"Oxudugu mekteb: {OxuduguMekteb}\nUniQebulBali: {UniQebulBali}\nIxtisas: {Ixtisas}\nBacariqlar: {Bacariqlar}\nIs tecrubesi: {Companies}\nIse Baslama tarixi: {StartWorkTime}\tBitirme tarixi: {StopWorkTime}\nBildiyi xarici diller: {BildiyiDiller}\nFerqlenme diplomu: {FerqlenmeDiplomu}\nGitLink: {GitLink}\nLinkedln: {Linkedln}\n";
            Console.ResetColor();
        }
    }
}


