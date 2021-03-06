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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class UpdateMPULayoutRequest : RpcAcsRequest<UpdateMPULayoutResponse>
    {
        public UpdateMPULayoutRequest()
            : base("rtc", "2018-01-11", "UpdateMPULayout", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<UserPanes> userPaness = new List<UserPanes>(){ };

		private int? backgroundColor;

		private int? cropMode;

		private List<long?> layoutIdss = new List<long?>(){ };

		private string taskId;

		private List<ClockWidgets> clockWidgetss = new List<ClockWidgets>(){ };

		private List<Watermarks> watermarkss = new List<Watermarks>(){ };

		private long? ownerId;

		private string appId;

		private List<Backgrounds> backgroundss = new List<Backgrounds>(){ };

		public List<UserPanes> UserPaness
		{
			get
			{
				return userPaness;
			}

			set
			{
				userPaness = value;
				for (int i = 0; i < userPaness.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".PaneId", userPaness[i].PaneId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".UserId", userPaness[i].UserId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".SourceType", userPaness[i].SourceType);
					for (int j = 0; j < userPaness[i].Imagess.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".Images." +(j + 1), userPaness[i].Imagess[j]);
					}
					for (int j = 0; j < userPaness[i].Textss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".Texts." +(j + 1), userPaness[i].Textss[j]);
					}
				}
			}
		}

		public int? BackgroundColor
		{
			get
			{
				return backgroundColor;
			}
			set	
			{
				backgroundColor = value;
				DictionaryUtil.Add(QueryParameters, "BackgroundColor", value.ToString());
			}
		}

		public int? CropMode
		{
			get
			{
				return cropMode;
			}
			set	
			{
				cropMode = value;
				DictionaryUtil.Add(QueryParameters, "CropMode", value.ToString());
			}
		}

		public List<long?> LayoutIdss
		{
			get
			{
				return layoutIdss;
			}

			set
			{
				layoutIdss = value;
				for (int i = 0; i < layoutIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LayoutIds." + (i + 1) , layoutIdss[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public List<ClockWidgets> ClockWidgetss
		{
			get
			{
				return clockWidgetss;
			}

			set
			{
				clockWidgetss = value;
				for (int i = 0; i < clockWidgetss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".X", clockWidgetss[i].X);
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".Y", clockWidgetss[i].Y);
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".FontType", clockWidgetss[i].FontType);
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".FontSize", clockWidgetss[i].FontSize);
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".FontColor", clockWidgetss[i].FontColor);
					DictionaryUtil.Add(QueryParameters,"ClockWidgets." + (i + 1) + ".ZOrder", clockWidgetss[i].ZOrder);
				}
			}
		}

		public List<Watermarks> Watermarkss
		{
			get
			{
				return watermarkss;
			}

			set
			{
				watermarkss = value;
				for (int i = 0; i < watermarkss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Url", watermarkss[i].Url);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Alpha", watermarkss[i].Alpha);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Display", watermarkss[i].Display);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".X", watermarkss[i].X);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Y", watermarkss[i].Y);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Width", watermarkss[i].Width);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Height", watermarkss[i].Height);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".ZOrder", watermarkss[i].ZOrder);
				}
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public List<Backgrounds> Backgroundss
		{
			get
			{
				return backgroundss;
			}

			set
			{
				backgroundss = value;
				for (int i = 0; i < backgroundss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Url", backgroundss[i].Url);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Display", backgroundss[i].Display);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".X", backgroundss[i].X);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Y", backgroundss[i].Y);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Width", backgroundss[i].Width);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Height", backgroundss[i].Height);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".ZOrder", backgroundss[i].ZOrder);
				}
			}
		}

		public class UserPanes
		{

			private int? paneId;

			private string userId;

			private string sourceType;

			private List<Images> imagess = new List<Images>(){ };

			private List<Texts> textss = new List<Texts>(){ };

			public int? PaneId
			{
				get
				{
					return paneId;
				}
				set	
				{
					paneId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public List<Images> Imagess
			{
				get
				{
					return imagess;
				}
				set	
				{
					imagess = value;
				}
			}

			public List<Texts> Textss
			{
				get
				{
					return textss;
				}
				set	
				{
					textss = value;
				}
			}

			public class Images
			{

				private string url;

				private int? display;

				private float? x;

				private float? y;

				private float? width;

				private float? height;

				private int? zOrder;

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public int? Display
				{
					get
					{
						return display;
					}
					set	
					{
						display = value;
					}
				}

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public float? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public float? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public int? ZOrder
				{
					get
					{
						return zOrder;
					}
					set	
					{
						zOrder = value;
					}
				}
			}

			public class Texts
			{

				private string text;

				private float? x;

				private float? y;

				private int? fontType;

				private int? fontSize;

				private int? fontColor;

				private int? zOrder;

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public int? FontType
				{
					get
					{
						return fontType;
					}
					set	
					{
						fontType = value;
					}
				}

				public int? FontSize
				{
					get
					{
						return fontSize;
					}
					set	
					{
						fontSize = value;
					}
				}

				public int? FontColor
				{
					get
					{
						return fontColor;
					}
					set	
					{
						fontColor = value;
					}
				}

				public int? ZOrder
				{
					get
					{
						return zOrder;
					}
					set	
					{
						zOrder = value;
					}
				}
			}
		}

		public class ClockWidgets
		{

			private float? x;

			private float? y;

			private int? fontType;

			private int? fontSize;

			private int? fontColor;

			private int? zOrder;

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public int? FontType
			{
				get
				{
					return fontType;
				}
				set	
				{
					fontType = value;
				}
			}

			public int? FontSize
			{
				get
				{
					return fontSize;
				}
				set	
				{
					fontSize = value;
				}
			}

			public int? FontColor
			{
				get
				{
					return fontColor;
				}
				set	
				{
					fontColor = value;
				}
			}

			public int? ZOrder
			{
				get
				{
					return zOrder;
				}
				set	
				{
					zOrder = value;
				}
			}
		}

		public class Watermarks
		{

			private string url;

			private float? alpha;

			private int? display;

			private float? x;

			private float? y;

			private float? width;

			private float? height;

			private int? zOrder;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public float? Alpha
			{
				get
				{
					return alpha;
				}
				set	
				{
					alpha = value;
				}
			}

			public int? Display
			{
				get
				{
					return display;
				}
				set	
				{
					display = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public float? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public float? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public int? ZOrder
			{
				get
				{
					return zOrder;
				}
				set	
				{
					zOrder = value;
				}
			}
		}

		public class Backgrounds
		{

			private string url;

			private int? display;

			private float? x;

			private float? y;

			private float? width;

			private float? height;

			private int? zOrder;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public int? Display
			{
				get
				{
					return display;
				}
				set	
				{
					display = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public float? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public float? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public int? ZOrder
			{
				get
				{
					return zOrder;
				}
				set	
				{
					zOrder = value;
				}
			}
		}

        public override UpdateMPULayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMPULayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
