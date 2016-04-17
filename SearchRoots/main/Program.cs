using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

using SearchRoots.solution;

namespace LabProject.SearchRoots
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*  string expression = "(Sin(0) + Cos(0)+Tan(0)) * 10";
              string updatedExpression = Regex.Replace(expression, @"(?<func>Sin|Cos|Tan)\((?<arg>.*?)\)", match =>
                          match.Groups["func"].Value == "Sin" ? Math.Sin(Int32.Parse(match.Groups["arg"].Value)).ToString() :
                          match.Groups["func"].Value == "Cos" ? Math.Cos(Int32.Parse(match.Groups["arg"].Value)).ToString() :
                          Math.Tan(Int32.Parse(match.Groups["arg"].Value)).ToString()
                      );
              var result = new DataTable().Compute(updatedExpression, null); // 10
              Console.WriteLine(result);*/
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SearchRootsForm());
            */
            solution.MyFunction fun = x => x * x - 10;
            solution.MyFunction der = x => 2 * x;
            // x*x = 10 <=> x = +- sqrt(10) = 3,...
            AIterationSearchRoot searchRoot1 = new Newton(fun, der, 5);
            Context c = new Context(searchRoot1);
            Decimal res1 = c.ExecuteOperation();
            Console.WriteLine(res1);
            
            AIterationSearchRoot searchRoot2 = new Bisection(fun, -2, 4);
            c.SetSearchRoot(searchRoot2);
            Decimal res2 = c.ExecuteOperation();
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
