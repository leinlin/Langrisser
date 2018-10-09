using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000717 RID: 1815
	[ProtoContract(Name = "DSHeroNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSHeroNtf : IExtensible
	{
		// Token: 0x0600601B RID: 24603 RVA: 0x001B28B4 File Offset: 0x001B0AB4
		public DSHeroNtf()
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

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x001B2928 File Offset: 0x001B0B28
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x001B2930 File Offset: 0x001B0B30
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x001B293C File Offset: 0x001B0B3C
		[ProtoMember(2, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProHero> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x001B2944 File Offset: 0x001B0B44
		// (set) Token: 0x06006020 RID: 24608 RVA: 0x001B294C File Offset: 0x001B0B4C
		[ProtoMember(3, IsRequired = true, Name = "ProtagonistId", DataFormat = DataFormat.TwosComplement)]
		public int ProtagonistId
		{
			get
			{
				return this._ProtagonistId;
			}
			set
			{
				this._ProtagonistId = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x001B2958 File Offset: 0x001B0B58
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x001B2960 File Offset: 0x001B0B60
		[ProtoMember(4, IsRequired = true, Name = "HeroInteractNumsFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long HeroInteractNumsFlushTime
		{
			get
			{
				return this._HeroInteractNumsFlushTime;
			}
			set
			{
				this._HeroInteractNumsFlushTime = value;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x001B296C File Offset: 0x001B0B6C
		// (set) Token: 0x06006024 RID: 24612 RVA: 0x001B2974 File Offset: 0x001B0B74
		[ProtoMember(5, IsRequired = true, Name = "HeroInteractNums", DataFormat = DataFormat.TwosComplement)]
		public int HeroInteractNums
		{
			get
			{
				return this._HeroInteractNums;
			}
			set
			{
				this._HeroInteractNums = value;
			}
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x001B2980 File Offset: 0x001B0B80
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x001B2990 File Offset: 0x001B0B90
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

		// Token: 0x06006027 RID: 24615 RVA: 0x001B2A5C File Offset: 0x001B0C5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSHeroNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047ED RID: 18413
		private uint _Version;

		// Token: 0x040047EE RID: 18414
		private readonly List<ProHero> _Heroes = new List<ProHero>();

		// Token: 0x040047EF RID: 18415
		private int _ProtagonistId;

		// Token: 0x040047F0 RID: 18416
		private long _HeroInteractNumsFlushTime;

		// Token: 0x040047F1 RID: 18417
		private int _HeroInteractNums;

		// Token: 0x040047F2 RID: 18418
		private IExtension extensionObject;

		// Token: 0x040047F3 RID: 18419
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047F4 RID: 18420
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047F5 RID: 18421
		private LuaFunction m_ctor_hotfix;
	}
}
