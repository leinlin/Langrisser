using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000771 RID: 1905
	[ProtoContract(Name = "GuildBasicSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildBasicSetReq : IExtensible
	{
		// Token: 0x060062EB RID: 25323 RVA: 0x001BCF2C File Offset: 0x001BB12C
		public GuildBasicSetReq()
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

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060062EC RID: 25324 RVA: 0x001BCF94 File Offset: 0x001BB194
		// (set) Token: 0x060062ED RID: 25325 RVA: 0x001BCF9C File Offset: 0x001BB19C
		[ProtoMember(1, IsRequired = true, Name = "AutoJoin", DataFormat = DataFormat.Default)]
		public bool AutoJoin
		{
			get
			{
				return this._AutoJoin;
			}
			set
			{
				this._AutoJoin = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x001BCFA8 File Offset: 0x001BB1A8
		// (set) Token: 0x060062EF RID: 25327 RVA: 0x001BCFB0 File Offset: 0x001BB1B0
		[ProtoMember(2, IsRequired = true, Name = "JoinLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinLevel
		{
			get
			{
				return this._JoinLevel;
			}
			set
			{
				this._JoinLevel = value;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x001BCFBC File Offset: 0x001BB1BC
		// (set) Token: 0x060062F1 RID: 25329 RVA: 0x001BCFC4 File Offset: 0x001BB1C4
		[ProtoMember(3, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x001BCFD0 File Offset: 0x001BB1D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x001BCFE0 File Offset: 0x001BB1E0
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

		// Token: 0x060062F4 RID: 25332 RVA: 0x001BD0AC File Offset: 0x001BB2AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildBasicSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A22 RID: 18978
		private bool _AutoJoin;

		// Token: 0x04004A23 RID: 18979
		private int _JoinLevel;

		// Token: 0x04004A24 RID: 18980
		private string _HiringDeclaration;

		// Token: 0x04004A25 RID: 18981
		private IExtension extensionObject;

		// Token: 0x04004A26 RID: 18982
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A27 RID: 18983
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A28 RID: 18984
		private LuaFunction m_ctor_hotfix;
	}
}
