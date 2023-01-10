using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1_Notlarım
{
    class Program
    {
        static void Main(string[] args)
        {
      
            
        }
    
       public int SingleNumber(int[] nums)
       {
            int sonuc = 0;
            foreach (var num in nums)
            {
                sonuc = num ^ sonuc;

            }
            return sonuc;
       }
        public bool checkPosibility(int[] nums)
        {
            int changedElement = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    changedElement++;
                    if (changedElement > 1)
                    {
                        return false;
                    }
                    if (i > 1 && nums[i] <= nums[i - 2])
                    {
                        nums[i] = nums[i - 1];
                    }
                }
            }
            return changedElement <= 1;
        }
        }
        
    }
}
