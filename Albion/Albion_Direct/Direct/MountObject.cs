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
    /* Internal type: a7n */
    public partial class MountObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a7n _internal;
        
        #region Properties
        
        public a7n MountObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public MountItemDescriptor GetDescriptor() => _internal.tf();
        public bool IsInRemountDistance() => _internal.ti();
        public bool IsLocalPlayers() => _internal.tg();
        
        #endregion
        
        #region Constructor
        
        public MountObject(a7n instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MountObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a7n(MountObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MountObject(a7n instance)
        {
            return new MountObject(instance);
        }
        
        public static implicit operator bool(MountObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
