////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.332.98217-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: afa */
    public partial struct Rectangle
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private afa _internal;
        
        #region Properties
        
        public afa Rectangle_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Rectangle(afa instance)
        {
            _internal = instance;
        }
        
        static Rectangle()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator afa(Rectangle instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Rectangle(afa instance)
        {
            return new Rectangle(instance);
        }
        #endregion
    }
}
