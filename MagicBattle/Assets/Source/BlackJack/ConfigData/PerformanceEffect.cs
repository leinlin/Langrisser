using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031D RID: 797
	[ProtoContract(Name = "PerformanceEffect")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class PerformanceEffect : IExtensible
	{
		// Token: 0x06002F41 RID: 12097 RVA: 0x000BC2B0 File Offset: 0x000BA4B0
		public PerformanceEffect()
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

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x000BC318 File Offset: 0x000BA518
		// (set) Token: 0x06002F43 RID: 12099 RVA: 0x000BC320 File Offset: 0x000BA520
		[ProtoMember(1, IsRequired = true, Name = "Anim", DataFormat = DataFormat.Default)]
		public string Anim
		{
			get
			{
				return this._Anim;
			}
			set
			{
				this._Anim = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x000BC32C File Offset: 0x000BA52C
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x000BC334 File Offset: 0x000BA534
		[ProtoMember(2, IsRequired = true, Name = "Word", DataFormat = DataFormat.TwosComplement)]
		public int Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				this._Word = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000BC340 File Offset: 0x000BA540
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x000BC348 File Offset: 0x000BA548
		[ProtoMember(3, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
		public string Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000BC354 File Offset: 0x000BA554
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000BC364 File Offset: 0x000BA564
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

		// Token: 0x06002F4A RID: 12106 RVA: 0x000BC430 File Offset: 0x000BA630
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PerformanceEffect));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002433 RID: 9267
		private string _Anim;

		// Token: 0x04002434 RID: 9268
		private int _Word;

		// Token: 0x04002435 RID: 9269
		private string _Voice;

		// Token: 0x04002436 RID: 9270
		private IExtension extensionObject;

		// Token: 0x04002437 RID: 9271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002438 RID: 9272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002439 RID: 9273
		private LuaFunction m_ctor_hotfix;
	}
}
