using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

/**
 * This file is part of the DynamicType.NET Project.
 * 
 * Copyright (c) 2012 iCept Media. All rights reserved.
 * 
 * DynamicType.NET is dual licensed BSD / LGPL.
 * 
 * See License.txt for more information.
 */

namespace DynamicType.NET {
    public class DynamicExpandoContainer : DynamicObject, IDictionary<string, object> {
        private readonly IDictionary<string, object> _data = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result) {
            if (!_data.ContainsKey(binder.Name)) {
                _data[binder.Name] = new DynamicValue();
            }

            result = _data[binder.Name];
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value) {
            _data[binder.Name] = value;

            return true;
        }

        public override bool TryDeleteMember(DeleteMemberBinder binder) {
            if (_data.ContainsKey(binder.Name)) {
                _data.Remove(binder.Name);

                return true;
            }

            return false;
        }

        #region Implementation of IEnumerable
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _data.GetEnumerator();
        }
        #endregion

        #region Implementation of ICollection<KeyValuePair<string,object>>
        public void Add(KeyValuePair<string, object> item) {
            _data.Add(item);
        }

        public void Clear() {
            _data.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item) {
            return _data.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) {
            _data.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, object> item) {
            return _data.Remove(item);
        }

        public int Count {
            get { return _data.Count; }
        }

        public bool IsReadOnly {
            get { return _data.IsReadOnly; }
        }
        #endregion

        #region Implementation of IDictionary<string,object>
        public bool ContainsKey(string key) {
            return _data.ContainsKey(key);
        }

        public void Add(string key, object value) {
            _data.Add(key, value);
        }

        public bool Remove(string key) {
            return _data.Remove(key);
        }

        public bool TryGetValue(string key, out object value) {
            return _data.TryGetValue(key, out value);
        }

        public object this[string key] {
            get { return _data[key]; }
            set { _data[key] = value; }
        }

        public ICollection<string> Keys {
            get { return _data.Keys; }
        }

        public ICollection<object> Values {
            get { return _data.Values; }
        }
        #endregion
    }
}