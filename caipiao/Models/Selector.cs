using System;
using System.Collections.Generic;

namespace caipiao
{
    /// <summary>
    /// 选号器类
    /// </summary>
    public class Selector
    {
        //属性
        /// <summary>
        /// 选择的号码(临时存储，打印完毕后保存起来，用来兑奖)
        /// </summary>
        public List<string[]> SelectedNums { get; set; }
        private Random objRandom = new Random();//生成随机数
        //方法
        /// <summary>
        /// 构造方法(初始化成员)
        /// </summary>
        public Selector()
        {
            this.SelectedNums = new List<string[]>();
        }
        public string[] CreateNum()
        {

            string[] numList = new string[7];
            for (int i = 0; i < 7; i++)
            {
                numList[i] = objRandom.Next(10).ToString();
            }
            return numList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        public void CreatGroupNums(int count)
        {
            SelectedNums.Clear();//首先清零
            for (int i = 0; i < count; i++)
            {
                SelectedNums.Add(CreateNum());//增加一组
            }
        }
        /// <summary>
        /// 获取打印格式的号码列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetPrintedNums()
        {
            List<string> numList = new List<string>();
            for (int i = 0; i < this.SelectedNums.Count; i++)
            {
                string printedNum = string.Empty;
                if (i < 9)
                {
                    printedNum = "第0" + (i + 1) + "组";
                }
                else
                {
                    printedNum = "第" + (i + 1) + "组";
                }
                for (int a = 0; a < this.SelectedNums[i].Length; a++)
                {
                    if(a==5)//最后的号特殊
                    {
                        printedNum += this.SelectedNums[i][a] + "    ";
                    }
                    else
                    {
                        printedNum += this.SelectedNums[i][a] + "  ";
                    }
                 
                }
                numList.Add(printedNum);
              
            }
            return numList;
        }

    }
}
