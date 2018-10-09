using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D7 RID: 2007
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroTrainningLevelAttackReq")]
	[Serializable]
	public class HeroTrainningLevelAttackReq : IExtensible
	{
		// Token: 0x06006664 RID: 26212 RVA: 0x001C8D08 File Offset: 0x001C6F08
		public HeroTrainningLevelAttackReq()
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

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x001C8D70 File Offset: 0x001C6F70
		// (set) Token: 0x06006666 RID: 26214 RVA: 0x001C8D78 File Offset: 0x001C6F78
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

		// Token: 0x06006667 RID: 26215 RVA: 0x001C8D84 File Offset: 0x001C6F84
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x001C8D94 File Offset: 0x001C6F94
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

		// Token: 0x06006669 RID: 26217 RVA: 0x001C8E60 File Offset: 0x001C7060
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CB2 RID: 19634
		private int _LevelId;

		// Token: 0x04004CB3 RID: 19635
		private IExtension extensionObject;

		// Token: 0x04004CB4 RID: 19636
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CB5 RID: 19637
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CB6 RID: 19638
		private LuaFunction m_ctor_hotfix;
	}
}
