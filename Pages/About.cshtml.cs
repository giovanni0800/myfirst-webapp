using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApplication.Pages
{
    public class AboutModel : PageModel
    {
        public bool hasData = false;
        private List<string> table;
        private double _valueTyped;
        public double ValueTyped { get { return _valueTyped; } }
        private int _maximumLegthOfMultiplicationTable = 70;
        public int MaximumLegthOfMultiplicationTable { get { return _maximumLegthOfMultiplicationTable; } }

        public void OnPost()
        {
            table = new List<string>();
            _valueTyped = Convert.ToDouble(Request.Form["inputReturnNumber"]);
            hasData = true;

            for(int index = 0; index <= MaximumLegthOfMultiplicationTable; index++)
            {
                table.Add($"{index} x {_valueTyped} = " + Convert.ToString((_valueTyped * index)));
            }
        }

        public string ShowTable(int index)
        {
            return $"Aqui está o resultado de: {table[index]}";
        }
    }
}
