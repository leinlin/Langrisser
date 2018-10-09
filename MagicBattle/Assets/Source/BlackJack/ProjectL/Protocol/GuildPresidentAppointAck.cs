using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000784 RID: 1924
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildPresidentAppointAck")]
	[Serializable]
	public class GuildPresidentAppointAck : IExtensible
	{
		// Token: 0x06006382 RID: 25474 RVA: 0x001BF1E8 File Offset: 0x001BD3E8
		public GuildPresidentAppointAck()
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

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06006383 RID: 25475 RVA: 0x001BF250 File Offset: 0x001BD450
		// (set) Token: 0x06006384 RID: 25476 RVA: 0x001BF258 File Offset: 0x001BD458
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

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x001BF264 File Offset: 0x001BD464
		// (set) Token: 0x06006386 RID: 25478 RVA: 0x001BF26C File Offset: 0x001BD46C
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

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x001BF278 File Offset: 0x001BD478
		// (set) Token: 0x06006388 RID: 25480 RVA: 0x001BF280 File Offset: 0x001BD480
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

		// Token: 0x06006389 RID: 25481 RVA: 0x001BF28C File Offset: 0x001BD48C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x001BF29C File Offset: 0x001BD49C
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

		// Token: 0x0600638B RID: 25483 RVA: 0x001BF368 File Offset: 0x001BD568
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildPresidentAppointAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A94 RID: 19092
		private int _Result;

		// Token: 0x04004A95 RID: 19093
		private string _UserId;

		// Token: 0x04004A96 RID: 19094
		private ProGuild _Guild;

		// Token: 0x04004A97 RID: 19095
		private IExtension extensionObject;

		// Token: 0x04004A98 RID: 19096
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A99 RID: 19097
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A9A RID: 19098
		private LuaFunction m_ctor_hotfix;
	}
}
