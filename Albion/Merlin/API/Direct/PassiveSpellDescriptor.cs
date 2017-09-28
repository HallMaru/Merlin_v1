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
    /* Internal type: ad8 */
    public partial class PassiveSpellDescriptor : SpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ad8 _internal;
        
        #region Properties
        
        public ad8 PassiveSpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public PassiveSpellDescriptor(ad8 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static PassiveSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ad8(PassiveSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PassiveSpellDescriptor(ad8 instance)
        {
            return new PassiveSpellDescriptor(instance);
        }
        
        public static implicit operator bool(PassiveSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
