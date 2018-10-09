using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000673 RID: 1651
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProHeroDungeonLevel")]
	[Serializable]
	public class ProHeroDungeonLevel : IExtensible
	{
		// Token: 0x060059EE RID: 23022 RVA: 0x0019EFBC File Offset: 0x0019D1BC
		public ProHeroDungeonLevel()
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

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x0019F024 File Offset: 0x0019D224
		// (set) Token: 0x060059F0 RID: 23024 RVA: 0x0019F02C File Offset: 0x0019D22C
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x0019F038 File Offset: 0x0019D238
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x0019F040 File Offset: 0x0019D240
		[ProtoMember(2, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x0019F04C File Offset: 0x0019D24C
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x0019F054 File Offset: 0x0019D254
		[ProtoMember(3, IsRequired = true, Name = "Stars", DataFormat = DataFormat.TwosComplement)]
		public int Stars
		{
			get
			{
				return this._Stars;
			}
			set
			{
				this._Stars = value;
			}
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x0019F060 File Offset: 0x0019D260
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0019F070 File Offset: 0x0019D270
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

		// Token: 0x060059F7 RID: 23031 RVA: 0x0019F13C File Offset: 0x0019D33C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroDungeonLevel));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400436C RID: 17260
		private int _LevelId;

		// Token: 0x0400436D RID: 17261
		private int _Nums;

		// Token: 0x0400436E RID: 17262
		private int _Stars;

		// Token: 0x0400436F RID: 17263
		private IExtension extensionObject;

		// Token: 0x04004370 RID: 17264
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004371 RID: 17265
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004372 RID: 17266
		private LuaFunction m_ctor_hotfix;
	}
}
