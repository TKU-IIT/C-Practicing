using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace{
	class cls{
		public int val;
		public bool flag;
		//Construce Proclaim
		public cls(int count){
			val =count;
		}
		public cls(bool flag1){
			flag = flag1;
		}

		public static cls operator +(){
			return new cls(c1.val - c2.val);
		}
	}
}
