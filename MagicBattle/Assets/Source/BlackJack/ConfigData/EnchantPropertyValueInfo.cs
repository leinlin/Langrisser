using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031C RID: 796
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EnchantPropertyValueInfo")]
	[Serializable]
	public class EnchantPropertyValueInfo : IExtensible
	{
		// Token: 0x06002F37 RID: 12087 RVA: 0x000BC0C8 File Offset: 0x000BA2C8
		public EnchantPropertyValueInfo()
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000BC130 File Offset: 0x000BA330
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x000BC138 File Offset: 0x000BA338
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000BC144 File Offset: 0x000BA344
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x000BC14C File Offset: 0x000BA34C
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

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000BC158 File Offset: 0x000BA358
		// (set) Token: 0x06002F3D RID: 12093 RVA: 0x000BC160 File Offset: 0x000BA360
		[ProtoMember(3, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000BC16C File Offset: 0x000BA36C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000BC17C File Offset: 0x000BA37C
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

		// Token: 0x06002F40 RID: 12096 RVA: 0x000BC248 File Offset: 0x000BA448
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EnchantPropertyValueInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400242C RID: 9260
		private int _Min;

		// Token: 0x0400242D RID: 9261
		private int _Max;

		// Token: 0x0400242E RID: 9262
		private int _Weight;

		// Token: 0x0400242F RID: 9263
		private IExtension extensionObject;

		// Token: 0x04002430 RID: 9264
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002431 RID: 9265
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002432 RID: 9266
		private LuaFunction m_ctor_hotfix;
	}
}
