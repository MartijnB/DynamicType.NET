using System.IO;
using System.Text;

namespace DynamicType.NET.Tests {
    public static class CodeGen {
        public static void GenerateBinairyOperatorCode() {
            var s = new StringBuilder();

            var types = new[] {
                                  "DynamicValue", /*"bool",*/ "byte", "sbyte", "char", "decimal", "double", "float",
                                  "int", "uint", "long", "ulong", "short", "ushort", "string"
                              };

            var operators = new[] {"+", "-", "*", "/", "%", "&", "|", "^", "<<", ">>"};

            foreach (string @operator in operators) {
                foreach (string type1 in types) {
                    string typeName = type1;

                    if ((@operator != "<<" && @operator != ">>") || typeName == "int") {
                        s.AppendLine("public static DynamicValue operator " + @operator + "(DynamicValue p1, " + typeName + " p2) {");

                        if (typeName == "DynamicValue") {
                            s.AppendLine("return new DynamicValue((dynamic)(p1.Value " + @operator + " (dynamic)p2.To(p1.Type)));");
                        }
                        else {
                            s.AppendLine("return new DynamicValue((dynamic)(p1.Value " + @operator + " (dynamic)DynamicConversion.To(p1.Type, p2)));");
                        }
                        s.AppendLine("}");
                        s.AppendLine();
                    }

                    if (typeName != "string" || @operator == "+") {
                        if (!(
                                 (@operator == "&" && typeName == "decimal") ||
                                 (@operator == "&" && typeName == "double") ||
                                 (@operator == "&" && typeName == "float") ||
                                 (@operator == "|" && typeName == "decimal") ||
                                 (@operator == "|" && typeName == "double") ||
                                 (@operator == "|" && typeName == "float") ||
                                 (@operator == "^" && typeName == "decimal") ||
                                 (@operator == "^" && typeName == "double") ||
                                 (@operator == "^" && typeName == "float")
                             )) {
                            if (@operator != "<<" && @operator != ">>") {
                                if (typeName != "DynamicValue") {
                                    s.AppendLine("public static DynamicValue operator " + @operator + "(" + typeName + " p1, DynamicValue p2) {");
                                    s.AppendLine("return new DynamicValue((" + typeName + ")(p1 " + @operator + " p2.To<" + typeName + ">()));");
                                    s.AppendLine("}");
                                    s.AppendLine();
                                }
                            }
                        }
                    }
                }
            }

            File.WriteAllText("code.cs", s.ToString());
        }

        public static void GenerateCompareOperatorCode() {
            var s = new StringBuilder();

            var types = new[] {
                                  "DynamicValue", "bool", "byte", "sbyte", "char", "decimal", "double", "float",
                                  "int", "uint", "long", "ulong", "short", "ushort", "string"
                              };

            var operators = new[] {"==", "!=", ">", "<", ">=", "<="};

            foreach (string @operator in operators) {
                foreach (string type1 in types) {
                    string typeName = type1;

                    s.AppendLine("public static bool operator " + @operator + "(DynamicValue p1, " + typeName + " p2) {");

                    if (typeName == "DynamicValue") {
                        s.AppendLine("return (p1.Value " + @operator + " (dynamic)p2.To(p1.Type));");
                    }
                    else {
                        s.AppendLine("return (p1.Value " + @operator + " (dynamic)DynamicConversion.To(p1.Type, p2));");
                    }
                    s.AppendLine("}");
                    s.AppendLine();
                }
            }

            File.WriteAllText("code.cs", s.ToString());
        }
    }
}