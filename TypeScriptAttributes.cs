using System;

namespace Alumis.Typescript.Attributes
{
    public class TypeScriptAttributes : Attribute
    {
        public bool Include { get; set; } = true;
        public Type MethodReturnType { get; set; }
    }
}