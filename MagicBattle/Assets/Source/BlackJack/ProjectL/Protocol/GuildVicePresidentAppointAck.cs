using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000776 RID: 1910
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildVicePresidentAppointAck")]
	[Serializable]
	public class GuildVicePresidentAppointAck : IExtensible
	{
		// Token: 0x0600631D RID: 25373 RVA: 0x001BD8B4 File Offset: 0x001BBAB4
		public GuildVicePresidentAppointAck()
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

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600631E RID: 25374 RVA: 0x001BD91C File Offset: 0x001BBB1C
		// (set) Token: 0x0600631F RID: 25375 RVA: 0x001BD924 File Offset: 0x001BBB24
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

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x001BD930 File Offset: 0x001BBB30
		// (set) Token: 0x06006321 RID: 25377 RVA: 0x001BD938 File Offset: 0x001BBB38
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x001BD944 File Offset: 0x001BBB44
		// (set) Token: 0x06006323 RID: 25379 RVA: 0x001BD94C File Offset: 0x001BBB4C
		[ProtoMember(3, IsRequired = true, Name = "Appoint", DataFormat = DataFormat.Default)]
		public bool Appoint
		{
			get
			{
				return this._Appoint;
			}
			set
			{
				this._Appoint = value;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x001BD958 File Offset: 0x001BBB58
		// (set) Token: 0x06006325 RID: 25381 RVA: 0x001BD960 File Offset: 0x001BBB60
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Guild", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006326 RID: 25382 RVA: 0x001BD96C File Offset: 0x001BBB6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x001BD97C File Offset: 0x001BBB7C
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

		// Token: 0x06006328 RID: 25384 RVA: 0x001BDA48 File Offset: 0x001BBC48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildVicePresidentAppointAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A45 RID: 19013
		private int _Result;

		// Token: 0x04004A46 RID: 19014
		private string _UserId;

		// Token: 0x04004A47 RID: 19015
		private bool _Appoint;

		// Token: 0x04004A48 RID: 19016
		private ProGuild _Guild;

		// Token: 0x04004A49 RID: 19017
		private IExtension extensionObject;

		// Token: 0x04004A4A RID: 19018
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A4B RID: 19019
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A4C RID: 19020
		private LuaFunction m_ctor_hotfix;
	}
}
