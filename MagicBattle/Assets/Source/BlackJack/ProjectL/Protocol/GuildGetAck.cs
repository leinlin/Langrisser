using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000774 RID: 1908
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildGetAck")]
	[Serializable]
	public class GuildGetAck : IExtensible
	{
		// Token: 0x06006309 RID: 25353 RVA: 0x001BD4E4 File Offset: 0x001BB6E4
		public GuildGetAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600630A RID: 25354 RVA: 0x001BD54C File Offset: 0x001BB74C
		// (set) Token: 0x0600630B RID: 25355 RVA: 0x001BD554 File Offset: 0x001BB754
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x001BD560 File Offset: 0x001BB760
		// (set) Token: 0x0600630D RID: 25357 RVA: 0x001BD568 File Offset: 0x001BB768
		[ProtoMember(2, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x001BD574 File Offset: 0x001BB774
		// (set) Token: 0x0600630F RID: 25359 RVA: 0x001BD57C File Offset: 0x001BB77C
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Guild", DataFormat = DataFormat.Default)]
		public ProGuild Guild
		{
			get
			{
				return this._Guild;
			}
			set
			{
				this._Guild = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x001BD588 File Offset: 0x001BB788
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x001BD590 File Offset: 0x001BB790
		[DefaultValue(0L)]
		[ProtoMember(4, IsRequired = false, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x001BD59C File Offset: 0x001BB79C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x001BD5AC File Offset: 0x001BB7AC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x001BD678 File Offset: 0x001BB878
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A37 RID: 18999
		private int _Result;

		// Token: 0x04004A38 RID: 19000
		private string _GuildId;

		// Token: 0x04004A39 RID: 19001
		private ProGuild _Guild;

		// Token: 0x04004A3A RID: 19002
		private long _LastUpdateTime;

		// Token: 0x04004A3B RID: 19003
		private IExtension extensionObject;

		// Token: 0x04004A3C RID: 19004
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A3D RID: 19005
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A3E RID: 19006
		private LuaFunction m_ctor_hotfix;
	}
}
