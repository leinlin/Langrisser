using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031E RID: 798
	[ProtoContract(Name = "FavourabilityPerformance")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FavourabilityPerformance : IExtensible
	{
		// Token: 0x06002F4B RID: 12107 RVA: 0x000BC498 File Offset: 0x000BA698
		public FavourabilityPerformance()
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000BC500 File Offset: 0x000BA700
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x000BC508 File Offset: 0x000BA708
		[ProtoMember(1, IsRequired = true, Name = "FavourabilityLevel", DataFormat = DataFormat.TwosComplement)]
		public int FavourabilityLevel
		{
			get
			{
				return this._FavourabilityLevel;
			}
			set
			{
				this._FavourabilityLevel = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000BC514 File Offset: 0x000BA714
		// (set) Token: 0x06002F4F RID: 12111 RVA: 0x000BC51C File Offset: 0x000BA71C
		[ProtoMember(2, IsRequired = true, Name = "PerformanceId", DataFormat = DataFormat.TwosComplement)]
		public int PerformanceId
		{
			get
			{
				return this._PerformanceId;
			}
			set
			{
				this._PerformanceId = value;
			}
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000BC528 File Offset: 0x000BA728
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000BC538 File Offset: 0x000BA738
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

		// Token: 0x06002F52 RID: 12114 RVA: 0x000BC604 File Offset: 0x000BA804
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FavourabilityPerformance));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400243A RID: 9274
		private int _FavourabilityLevel;

		// Token: 0x0400243B RID: 9275
		private int _PerformanceId;

		// Token: 0x0400243C RID: 9276
		private IExtension extensionObject;

		// Token: 0x0400243D RID: 9277
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400243E RID: 9278
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400243F RID: 9279
		private LuaFunction m_ctor_hotfix;
	}
}
