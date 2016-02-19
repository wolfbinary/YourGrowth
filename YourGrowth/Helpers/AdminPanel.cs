using System;

namespace YourGrowth.Web.Helpers
{
    public class AdminHelper
    {
        public static string AdminPanel(string id, string linkTitle, string panelId, string innerHtml)
        {
            return string.Format(@"
                <a href="#">{0}</a>
        < div id = \"{1}" class="panel">
            <div class="panel-body">

            </div>
        </div>
");
        }
    }
}