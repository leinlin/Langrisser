using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CA RID: 1994
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CharSkinTakeOffAck")]
	[Serializable]
	public class CharSkinTakeOffAck : IExtensible
	{
		// Token: 0x060065EA RID: 26090 RVA: 0x001C7490 File Offset: 0x001C5690
		public CharSkinTakeOffAck()
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

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x001C74F8 File Offset: 0x001C56F8
		// (set) Token: 0x060065EC RID: 26092 RVA: 0x001C7500 File Offset: 0x001C5700
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

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060065ED RID: 26093 RVA: 0x001C750C File Offset: 0x001C570C
		// (set) Token: 0x060065EE RID: 26094 RVA: 0x001C7514 File Offset: 0x001C5714
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x001C7520 File Offset: 0x001C5720
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x001C7530 File Offset: 0x001C5730
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

		// Token: 0x060065F1 RID: 26097 RVA: 0x001C75FC File Offset: 0x001C57FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CharSkinTakeOffAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C5B RID: 19547
		private int _Result;

		// Token: 0x04004C5C RID: 19548
		private int _HeroId;

		// Token: 0x04004C5D RID: 19549
		private IExtension extensionObject;

		// Token: 0x04004C5E RID: 19550
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C5F RID: 19551
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C60 RID: 19552
		private LuaFunction m_ctor_hotfix;
	}
}
