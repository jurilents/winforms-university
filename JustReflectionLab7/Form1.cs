using System.Reflection;

namespace JustReflectionLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private record struct MyNode(string DisplayName)
        {
            private readonly List<MyNode> _children = new();

            public IEnumerable<MyNode> Children => _children;
            public bool HasChildren => _children.Count > 0;

            public void AddChild(MyNode node) => _children.Add(node);
        }


        private void submit_Click(object sender, EventArgs e)
        {
            var nodes = ReflectionMagic(classNameInput.Text);
            if (nodes != null)
            {
                treeView.Nodes.Clear();
                RenderTreeView(nodes);
            }
        }

        private IEnumerable<MyNode>? ReflectionMagic(string targetClassName)
        {
            const BindingFlags allFlags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static;
            var type = Type.GetType(targetClassName);
            messageOutput.Text = type == null ? "Type not found :(" : "";
            if (type == null) return null;

            var nodes = new List<MyNode>();

            // Constructors
            var constructorsNode = new MyNode("Constructors");
            var constructors = type.GetConstructors(allFlags);

            foreach (var constructor in constructors)
            {
                var ctorArgs = string.Join(", ", constructor.GetParameters().Select(p => $"{GetDisplayNameOfType(p.ParameterType)} {p.Name}"));
                var ctor = new MyNode($"{constructor.GetAccessModifierName()} {type.Name}({ctorArgs})");

                constructorsNode.AddChild(ctor);
            }

            if (constructorsNode.HasChildren)
                nodes.Add(constructorsNode);

            // Properties
            var propertiesNode = new MyNode("Properties");
            var properties = type.GetProperties(allFlags);

            foreach (var property in properties)
            {
                var propAccessMod = property.GetAccessModifier();
                var getter = property.GetGetMethod(true);
                var getterDisp = getter == null
                    ? ""
                    : getter.GetAccessModifier() == propAccessMod
                     ? "get;"
                     : getter.GetAccessModifierName() + " get;";


                var setter = property.GetSetMethod(true);
                var setterDisp = setter == null
                    ? ""
                    : setter.GetAccessModifier() == propAccessMod
                     ? "set;"
                     : setter.GetAccessModifierName() + " set;";

                var typeName = GetDisplayNameOfType(property.PropertyType);
                var prop = new MyNode($"{propAccessMod.ToString().ToLower()} {typeName} {property.Name} {{ {getterDisp} {setterDisp} }}");

                propertiesNode.AddChild(prop);
            }

            if (propertiesNode.HasChildren)
                nodes.Add(propertiesNode);

            // Methods
            var methodsNode = new MyNode("Methods");
            var methods = type.GetMethods(allFlags).Where(m => !m.IsSpecialName); // methods without props accessors

            foreach (var method in methods)
            {
                var methArgs = string.Join(", ", method.GetParameters().Select(p => $"{GetDisplayNameOfType(p.ParameterType)} {p.Name}"));
                var meth = new MyNode($"{method.GetAccessModifierName()} {GetDisplayNameOfType(method.ReturnType)} {method.Name}({methArgs})");

                methodsNode.AddChild(meth);
            }

            if (methodsNode.HasChildren)
                nodes.Add(methodsNode);

            return nodes;
        }

        private static string GetDisplayNameOfType(Type type)
        {
            if (type.IsGenericType)
            {
                var name = type.Name[..(type.Name.IndexOf('`'))];
                return $"{name}<{string.Join(", ", type.GetGenericArguments().Select(a => a.Name))}>";
            }

            return type.Name;
        }

        private void RenderTreeView(IEnumerable<MyNode> nodes, TreeNode? parentNode = null)
        {
            foreach (var node in nodes)
            {
                var currentNode = parentNode == null
                                ? treeView.Nodes.Add(node.DisplayName) // if root
                                : parentNode.Nodes.Add(node.DisplayName); // if nested
                if (node.HasChildren)
                    RenderTreeView(node.Children, currentNode); // recustion
                currentNode.Expand();
            }
        }
    }
}