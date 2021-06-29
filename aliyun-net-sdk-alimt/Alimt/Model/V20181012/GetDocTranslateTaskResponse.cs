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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.alimt.Model.V20181012
{
	public class GetDocTranslateTaskResponse : AcsResponse
	{

		private string requestId;

		private string taskId;

		private string status;

		private string translateFileUrl;

		private string translateErrorCode;

		private string translateErrorMessage;

		private int? pageCount;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string TranslateFileUrl
		{
			get
			{
				return translateFileUrl;
			}
			set	
			{
				translateFileUrl = value;
			}
		}

		public string TranslateErrorCode
		{
			get
			{
				return translateErrorCode;
			}
			set	
			{
				translateErrorCode = value;
			}
		}

		public string TranslateErrorMessage
		{
			get
			{
				return translateErrorMessage;
			}
			set	
			{
				translateErrorMessage = value;
			}
		}

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}
	}
}
