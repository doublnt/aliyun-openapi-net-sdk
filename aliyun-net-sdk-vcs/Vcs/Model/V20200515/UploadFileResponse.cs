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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class UploadFileResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private UploadFile_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public UploadFile_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class UploadFile_Data
		{

			private List<UploadFile_OssPath> records;

			public List<UploadFile_OssPath> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class UploadFile_OssPath
			{

				private string ossPath;

				private string sourceId;

				public string OssPath
				{
					get
					{
						return ossPath;
					}
					set	
					{
						ossPath = value;
					}
				}

				public string SourceId
				{
					get
					{
						return sourceId;
					}
					set	
					{
						sourceId = value;
					}
				}
			}
		}
	}
}
