using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068C RID: 1676
	[ProtoContract(Name = "ProRangeInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRangeInfo : IExtensible
	{
		// Token: 0x06005B36 RID: 23350 RVA: 0x001A22E4 File Offset: 0x001A04E4
		public ProRangeInfo()
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

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x001A234C File Offset: 0x001A054C
		// (set) Token: 0x06005B38 RID: 23352 RVA: 0x001A2354 File Offset: 0x001A0554
		[ProtoMember(1, IsRequired = true, Name = "Min", DataFormat = DataFormat.TwosComplement)]
		public int Min
		{
			get
			{
				return this._Min;
			}
			set
			{
				this._Min = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x001A2360 File Offset: 0x001A0560
		// (set) Token: 0x06005B3A RID: 23354 RVA: 0x001A2368 File Offset: 0x001A0568
		[ProtoMember(2, IsRequired = true, Name = "Max", DataFormat = DataFormat.TwosComplement)]
		public int Max
		{
			get
			{
				return this._Max;
			}
			set
			{
				this._Max = value;
			}
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x001A2374 File Offset: 0x001A0574
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x001A2384 File Offset: 0x001A0584
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

		// Token: 0x06005B3D RID: 23357 RVA: 0x001A2450 File Offset: 0x001A0650
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRangeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004448 RID: 17480
		private int _Min;

		// Token: 0x04004449 RID: 17481
		private int _Max;

		// Token: 0x0400444A RID: 17482
		private IExtension extensionObject;

		// Token: 0x0400444B RID: 17483
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400444C RID: 17484
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400444D RID: 17485
		private LuaFunction m_ctor_hotfix;
	}
}
