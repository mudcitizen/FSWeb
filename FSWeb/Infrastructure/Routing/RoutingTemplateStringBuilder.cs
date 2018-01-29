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
            AddParameterAndValue(RoutingConstants.Terms.Controller, controllerName);
        }
        public void AddAction(string actionName)
        {
            AddParameterAndValue(RoutingConstants.Terms.Action, actionName);
        }

        public void AddLiteral(String text)
        {
            sb.Append(text);
        }
        public void AddParameter(String text)
        {
            sb.Append(RoutingConstants.Terms.ParameterOpeningDelimiter + text + RoutingConstants.Terms.ParameterClosingDelimiter);
        }
        public void AddNullableParameter(String text)
        {
            sb.Append(RoutingConstants.Terms.ParameterOpeningDelimiter + text + RoutingConstants.Terms.ParameterClosingDelimiter);
        }
        public void Seperate()
        {
            sb.Append(RoutingConstants.Terms.Seperator);
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        void AddParameterAndValue(String parameterName, String parameterValue)
        {
            sb.Append(RoutingConstants.Terms.ParameterOpeningDelimiter);
            sb.Append(parameterName);
            sb.Append(RoutingConstants.Terms.Equal);
            sb.Append(parameterValue);
            sb.Append(RoutingConstants.Terms.ParameterClosingDelimiter);
        }
    }
}
