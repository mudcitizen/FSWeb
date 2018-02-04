using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSWeb.Infrastructure.Routing
{
    public class RoutingTemplateStringBuilder
    {
        StringBuilder sb;
        public RoutingTemplateStringBuilder()
        {
            sb = new StringBuilder();
        }

        public void AddController(string controllerName)
        {
            AddParameterAndValue(RoutingConstants.Term.Controller, controllerName);
        }
        public void AddAction(string actionName)
        {
            AddParameterAndValue(RoutingConstants.Term.Action, actionName);
        }

        public void AddLiteral(String text)
        {
            sb.Append(text);
        }
        public void AddParameter(String text)
        {
            sb.Append(RoutingConstants.Term.ParameterOpeningDelimiter + text + RoutingConstants.Term.ParameterClosingDelimiter);
        }
        public void AddNullableParameter(String text)
        {
            sb.Append(RoutingConstants.Term.ParameterOpeningDelimiter + text + RoutingConstants.Term.ParameterClosingDelimiter);
        }
        public void Seperate()
        {
            sb.Append(RoutingConstants.Term.Seperator);
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        void AddParameterAndValue(String parameterName, String parameterValue)
        {
            sb.Append(RoutingConstants.Term.ParameterOpeningDelimiter);
            sb.Append(parameterName);
            sb.Append(RoutingConstants.Term.Equal);
            sb.Append(parameterValue);
            sb.Append(RoutingConstants.Term.ParameterClosingDelimiter);
        }

        public static String AsParameter(String text) {
            return RoutingConstants.Term.ParameterOpeningDelimiter + text + RoutingConstants.Term.ParameterClosingDelimiter;
        }
    }
}
