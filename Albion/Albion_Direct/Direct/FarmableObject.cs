////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.114130-prod
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

namespace Albion_Direct
{
    /* Internal type: a6l */
    public partial class FarmableObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a6l _internal;
        
        #region Properties
        
        public a6l FarmableObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FarmableObject(a6l instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FarmableObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a6l(FarmableObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FarmableObject(a6l instance)
        {
            return new FarmableObject(instance);
        }
        
        public static implicit operator bool(FarmableObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
