using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000645 RID: 1605
	[ProtoContract(Name = "ProRiftLevel")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRiftLevel : IExtensible
	{
		// Token: 0x060057CC RID: 22476 RVA: 0x0019930C File Offset: 0x0019750C
		public ProRiftLevel()
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

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x00199374 File Offset: 0x00197574
		// (set) Token: 0x060057CE RID: 22478 RVA: 0x0019937C File Offset: 0x0019757C
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

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x060057CF RID: 22479 RVA: 0x00199388 File Offset: 0x00197588
		// (set) Token: 0x060057D0 RID: 22480 RVA: 0x00199390 File Offset: 0x00197590
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x0019939C File Offset: 0x0019759C
		// (set) Token: 0x060057D2 RID: 22482 RVA: 0x001993A4 File Offset: 0x001975A4
		[ProtoMember(3, IsRequired = true, Name = "Star", DataFormat = DataFormat.TwosComplement)]
		public int Star
		{
			get
			{
				return this._Star;
			}
			set
			{
				this._Star = value;
			}
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x001993B0 File Offset: 0x001975B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x001993C0 File Offset: 0x001975C0
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

		// Token: 0x060057D5 RID: 22485 RVA: 0x0019948C File Offset: 0x0019768C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRiftLevel));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041EC RID: 16876
		private int _LevelId;

		// Token: 0x040041ED RID: 16877
		private int _Nums;

		// Token: 0x040041EE RID: 16878
		private int _Star;

		// Token: 0x040041EF RID: 16879
		private IExtension extensionObject;

		// Token: 0x040041F0 RID: 16880
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041F1 RID: 16881
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041F2 RID: 16882
		private LuaFunction m_ctor_hotfix;
	}
}
