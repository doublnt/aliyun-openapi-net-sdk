/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class AddDomainResponseUnmarshaller
    {
        public static AddDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddDomainResponse addDomainResponse = new AddDomainResponse();

			addDomainResponse.HttpResponse = _ctx.HttpResponse;
			addDomainResponse.RequestId = _ctx.StringValue("AddDomain.RequestId");
			addDomainResponse.DomainId = _ctx.StringValue("AddDomain.DomainId");
			addDomainResponse.DomainName = _ctx.StringValue("AddDomain.DomainName");
			addDomainResponse.PunyCode = _ctx.StringValue("AddDomain.PunyCode");
			addDomainResponse.GroupId = _ctx.StringValue("AddDomain.GroupId");
			addDomainResponse.GroupName = _ctx.StringValue("AddDomain.GroupName");

			List<string> addDomainResponse_dnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("AddDomain.DnsServers.Length"); i++) {
				addDomainResponse_dnsServers.Add(_ctx.StringValue("AddDomain.DnsServers["+ i +"]"));
			}
			addDomainResponse.DnsServers = addDomainResponse_dnsServers;
        
			return addDomainResponse;
        }
    }
}
