﻿#region BSD License
/* 
Copyright (c) 2010, NETFx
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

* Neither the name of Clarius Consulting nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Collections;
using System.Web;

namespace System.Net.Http
{
	public class HttpNameValueCollection : NameValueCollection
	{
		public HttpNameValueCollection()
			: base(StringComparer.OrdinalIgnoreCase)
		{
		}

		protected HttpNameValueCollection(SerializationInfo info, StreamingContext context)
			: base(info, context) { }

		public HttpNameValueCollection Add(string name, params string[] values)
		{
			foreach (var value in values)
			{
				base.Add(name, value);
			}

			return this;
		}

        public static HttpNameValueCollection Parse(string query)
        {
            var tokens = query
                .Split(new char [] { '&' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Uri.UnescapeDataString);
            HttpNameValueCollection result = new HttpNameValueCollection();
            
            tokens
                .Select(t => t.Split(new char [] { '=' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(pair => new { Key = pair[0], Value = (pair.Length > 1) ? pair[1] : "" })
                .ToList()
                .ForEach(pair => result.Add(pair.Key, pair.Value));

            return result;
        }

		public override string ToString()
		{
            return  String.Join("&",
                    this.AllKeys.Select(k =>  Uri.EscapeUriString(k + "=" + this[k])).ToArray());
		}
	}
}