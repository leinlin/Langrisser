using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000319 RID: 793
	[ProtoContract(Name = "HeroConfessionUnlockCondition")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroConfessionUnlockCondition : IExtensible
	{
		// Token: 0x06002F1B RID: 12059 RVA: 0x000BBB24 File Offset: 0x000B9D24
		public HeroConfessionUnlockCondition()
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000BBB8C File Offset: 0x000B9D8C
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x000BBB94 File Offset: 0x000B9D94
		[ProtoMember(1, IsRequired = true, Name = "FetterId", DataFormat = DataFormat.TwosComplement)]
		public int FetterId
		{
			get
			{
				return this._FetterId;
			}
			set
			{
				this._FetterId = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000BBBA0 File Offset: 0x000B9DA0
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x000BBBA8 File Offset: 0x000B9DA8
		[ProtoMember(2, IsRequired = true, Name = "FetterLevel", DataFormat = DataFormat.TwosComplement)]
		public int FetterLevel
		{
			get
			{
				return this._FetterLevel;
			}
			set
			{
				this._FetterLevel = value;
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x000BBBB4 File Offset: 0x000B9DB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000BBBC4 File Offset: 0x000B9DC4
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

		// Token: 0x06002F22 RID: 12066 RVA: 0x000BBC90 File Offset: 0x000B9E90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroConfessionUnlockCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002418 RID: 9240
		private int _FetterId;

		// Token: 0x04002419 RID: 9241
		private int _FetterLevel;

		// Token: 0x0400241A RID: 9242
		private IExtension extensionObject;

		// Token: 0x0400241B RID: 9243
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400241C RID: 9244
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400241D RID: 9245
		private LuaFunction m_ctor_hotfix;
	}
}
