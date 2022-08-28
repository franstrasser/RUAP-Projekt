using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Ruap
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string api= "https://ussouthcentral.services.azureml.net/workspaces/b794eebef078478981e4d6b73ce91c9d/services/5be9b1fef5154ef49cfc17472e44ff67/execute?api-version=2.0&details=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lbPredict_Click(object sender, EventArgs e)
        {
            int anaemia, diabetes, bloodPressure, gender, smoking;
            if (rblAnaemia.SelectedItem.Text == "Yes") anaemia = 1;
            else anaemia = 0;
            if (rblDiabetes.SelectedItem.Text == "Yes") diabetes = 1;
            else diabetes = 0;
            if (rblBloodPressure.SelectedItem.Text == "Yes") bloodPressure = 1;
            else bloodPressure = 0;
            if (rblSmoking.SelectedItem.Text == "Yes") smoking = 1;
            else smoking = 0;
            if (rblGender.SelectedItem.Text == "Male") gender = 1;
            else gender = 0;
            var client = new RestClient(api);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization",
            "Bearer gIdK9gCapwTMbegdRD8nPpAaby2jfSRP73wUYKHMgOD76zJvMVXhazcyyfKC+0/82jFDCUdBAAi/+AMCsKQjtQ==");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""Inputs"": {
" + "\n" +
            @"        ""input1"": {
" + "\n" +
            @"            ""ColumnNames"": [
" + "\n" +
            @"                ""age"",
" + "\n" +
            @"                ""anaemia"",
" + "\n" +
            @"                ""creatinine_phosphokinase"",
" + "\n" +
            @"                ""diabetes"",
" + "\n" +
            @"                ""ejection_fraction"",
" + "\n" +
            @"                ""high_blood_pressure"",
" + "\n" +
            @"                ""platelets"",
" + "\n" +
            @"                ""serum_creatinine"",
" + "\n" +
            @"                ""serum_sodium"",
" + "\n" +
            @"                ""sex"",
" + "\n" +
            @"                ""smoking"",
" + "\n" +
            @"                ""time"",
" + "\n" +
            @"                ""DEATH_EVENT""
" + "\n" +
            @"            ],
" + "\n" +
            @"            ""Values"": [
" + "\n" +
            @"                [
" + "\n" +
            @"                    """+txtAge.Text+@""",
" + "\n" +
            @"                    """ + anaemia + @""",
" + "\n" +
            @"                    """ + txtCreatinine.Text + @""",
" + "\n" +
            @"                    """ + diabetes + @""",
" + "\n" +
            @"                    """ + txtEjection.Text + @""",
" + "\n" +
            @"                    """ + bloodPressure + @""",
" + "\n" +
            @"                    """ + txtPlatelets.Text + @""",
" + "\n" +
            @"                    """ + txtSerumCreatinine.Text + @""",
" + "\n" +
            @"                    """ + txtSerumSodium.Text + @""",
" + "\n" +
            @"                    """ + gender + @""",
" + "\n" +
            @"                    """ + smoking + @""",
" + "\n" +
            @"                    ""1"",
" + "\n" +
            @"                    ""0""
" + "\n" +
            @"                ]
" + "\n" +
            @"            ]
" + "\n" +
            @"        }
" + "\n" +
            @"    },
" + "\n" +
            @"    ""GlobalParameters"": {}
" + "\n" +
            @"}";
            request.AddParameter("application /json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            var results = JObject.Parse(response.Content);
            string willDie=results["Results"]["output1"]["value"]["Values"][0][11].ToString();
            string prediction = results["Results"]["output1"]["value"]["Values"][0][12].ToString();
            int death= int.Parse(willDie, CultureInfo.InvariantCulture.NumberFormat);
            float percent= float.Parse(prediction, CultureInfo.InvariantCulture.NumberFormat);
            if (death == 1)
            {
                lblResults.Text = "Model is " + percent.ToString("#0.##%") + " sure that the person will die in case of heart failure.";
            }
            else
            {
                lblResults.Text = "Model is " + percent.ToString("#0.##%") + " sure that the person will survive in case of heart failure.";
            }
        }
    }
}