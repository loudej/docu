using System.Collections.Generic;
using Docu.Documentation.Comments;
using Docu.Parsing.Model;

namespace Docu.Documentation
{
    public interface IDocumentationElement
    {
        string Name { get; }
        bool IsExternal { get; }
        bool IsResolved { get; }
        Summary Summary { get; set; }
        Remarks Remarks { get; set; }
        bool IsIdentifiedBy(Identifier otherIdentifier);
        void ConvertToExternalReference();
    }
}