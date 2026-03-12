using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels

    /// What You Can Write Inside The Class Or Struct?
    /// 1. Fields (Attributes) 
    /// 2. Methods
    /// 3. Constructor => special Method
    /// 4. Properties
    /// 5. Events
    /// 6. Indexers

    /// What You Can Write Inside The Interface?
    /// 1. Method Signature
    /// 2. Property Signature
    /// 3. Event Signature
    /// 4. Indexer Signature
    /// 5. Default Implementation (C# 8.0 +)

    /// Allowed Access Modifiers Inside The Namespace 
    /// 1. public
    /// 2. internal [Default Access Modifier]

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class 
        /// 1. private [default]
        /// 2. private protected
        /// 3. protected
        /// 4. internal
        /// 5. internal protected
        /// 6. public

        int x; // private
        internal int y; // assembly only
        public int z; // all

        public TypeA()
        {
            x = 0;
            y = 0;
            z = 0;
        }
    }
}
