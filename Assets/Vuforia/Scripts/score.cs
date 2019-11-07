using System.Collections;
using System.Collections.Generic;
namespace scoresclass{
    public class score
    {
        public int time;
        public string phone,pr1,pr2,pr3;
        public score() {
    }
        public score(string p1,string p2,string p3,int tt,string phn){
            pr1=p1;
            pr2=p2;
            pr3=p3;
            phone=phn;
            time=tt;
        }
    }
}
