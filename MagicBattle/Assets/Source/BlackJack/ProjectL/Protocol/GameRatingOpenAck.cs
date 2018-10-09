using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000703 RID: 1795
	[ProtoContract(Name = "GameRatingOpenAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GameRatingOpenAck : IExtensible
	{
		// Token: 0x06005F5F RID: 24415 RVA: 0x001B02F8 File Offset: 0x001AE4F8
		public GameRatingOpenAck()
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

		// Token: 0x06005F60 RID: 24416 RVA: 0x001B0360 File Offset: 0x001AE560
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x001B0370 File Offset: 0x001AE570
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

		// Token: 0x06005F62 RID: 24418 RVA: 0x001B043C File Offset: 0x001AE63C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GameRatingOpenAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004766 RID: 18278
		private IExtension extensionObject;

		// Token: 0x04004767 RID: 18279
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004768 RID: 18280
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004769 RID: 18281
		private LuaFunction m_ctor_hotfix;
	}
}
