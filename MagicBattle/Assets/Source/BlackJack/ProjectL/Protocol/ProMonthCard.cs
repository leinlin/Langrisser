using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000699 RID: 1689
	[ProtoContract(Name = "ProMonthCard")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProMonthCard : IExtensible
	{
		// Token: 0x06005BA9 RID: 23465 RVA: 0x001A3B68 File Offset: 0x001A1D68
		public ProMonthCard()
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

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06005BAA RID: 23466 RVA: 0x001A3BD0 File Offset: 0x001A1DD0
		// (set) Token: 0x06005BAB RID: 23467 RVA: 0x001A3BD8 File Offset: 0x001A1DD8
		[ProtoMember(1, IsRequired = true, Name = "MonthCardId", DataFormat = DataFormat.TwosComplement)]
		public int MonthCardId
		{
			get
			{
				return this._MonthCardId;
			}
			set
			{
				this._MonthCardId = value;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x001A3BE4 File Offset: 0x001A1DE4
		// (set) Token: 0x06005BAD RID: 23469 RVA: 0x001A3BEC File Offset: 0x001A1DEC
		[ProtoMember(2, IsRequired = true, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public long ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x001A3BF8 File Offset: 0x001A1DF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x001A3C08 File Offset: 0x001A1E08
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

		// Token: 0x06005BB0 RID: 23472 RVA: 0x001A3CD4 File Offset: 0x001A1ED4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProMonthCard));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044A0 RID: 17568
		private int _MonthCardId;

		// Token: 0x040044A1 RID: 17569
		private long _ExpiredTime;

		// Token: 0x040044A2 RID: 17570
		private IExtension extensionObject;

		// Token: 0x040044A3 RID: 17571
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044A4 RID: 17572
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044A5 RID: 17573
		private LuaFunction m_ctor_hotfix;
	}
}
