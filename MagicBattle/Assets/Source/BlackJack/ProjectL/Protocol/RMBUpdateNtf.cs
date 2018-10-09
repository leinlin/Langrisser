using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000744 RID: 1860
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RMBUpdateNtf")]
	[Serializable]
	public class RMBUpdateNtf : IExtensible
	{
		// Token: 0x060061AB RID: 25003 RVA: 0x001B7E1C File Offset: 0x001B601C
		public RMBUpdateNtf()
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

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060061AC RID: 25004 RVA: 0x001B7E84 File Offset: 0x001B6084
		// (set) Token: 0x060061AD RID: 25005 RVA: 0x001B7E8C File Offset: 0x001B608C
		[ProtoMember(1, IsRequired = true, Name = "RMBNums", DataFormat = DataFormat.TwosComplement)]
		public long RMBNums
		{
			get
			{
				return this._RMBNums;
			}
			set
			{
				this._RMBNums = value;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060061AE RID: 25006 RVA: 0x001B7E98 File Offset: 0x001B6098
		// (set) Token: 0x060061AF RID: 25007 RVA: 0x001B7EA0 File Offset: 0x001B60A0
		[ProtoMember(2, IsRequired = true, Name = "RechargeTime", DataFormat = DataFormat.TwosComplement)]
		public long RechargeTime
		{
			get
			{
				return this._RechargeTime;
			}
			set
			{
				this._RechargeTime = value;
			}
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x001B7EAC File Offset: 0x001B60AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x001B7EBC File Offset: 0x001B60BC
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

		// Token: 0x060061B2 RID: 25010 RVA: 0x001B7F88 File Offset: 0x001B6188
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RMBUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004925 RID: 18725
		private long _RMBNums;

		// Token: 0x04004926 RID: 18726
		private long _RechargeTime;

		// Token: 0x04004927 RID: 18727
		private IExtension extensionObject;

		// Token: 0x04004928 RID: 18728
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004929 RID: 18729
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400492A RID: 18730
		private LuaFunction m_ctor_hotfix;
	}
}
