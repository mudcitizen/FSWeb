using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Infrastructure.Routing
{
    public static class RoutingConstants
    {
        public static class Term
        {
            public static String Controller => "controller";
            public static String Action => "action";
            public static String Template => "template";
            public static String Defaults => "defaults";
            public static String ParameterOpeningDelimiter => "{";
            public static String ParameterClosingDelimiter => "}";
            public static String Seperator => "/";
            public static String Equal => "=";
            public static String QuestionMark => "?";

        }

        public static class Controller
        {
            public static String Home => "Home";
            public static String Item => "Item";
        }
        public static class Action
        {
            public static String Index => "Index";
            public static String Display => "Display";
        }

        public static class StaticText
        {
            public static String Page = "Page";
        }
        public static class ParameterName
        {
            public static String Id = "id";
            public static String Page = "page";
        }

        public static class Segment
        {
            public static String Category = "category";
            public static String Page = "page";
        }
    }
}
