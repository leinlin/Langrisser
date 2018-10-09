using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000244 RID: 580
	[ProtoContract(Name = "ConfigDataHeroBiographyInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroBiographyInfo : IExtensible
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x000A60C8 File Offset: 0x000A42C8
		public ConfigDataHeroBiographyInfo()
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

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000A613C File Offset: 0x000A433C
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x000A6144 File Offset: 0x000A4344
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000A6150 File Offset: 0x000A4350
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x000A6158 File Offset: 0x000A4358
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000A6164 File Offset: 0x000A4364
		[ProtoMember(4, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<HeroBiographyCondition> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000A616C File Offset: 0x000A436C
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x000A6174 File Offset: 0x000A4374
		[ProtoMember(5, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000A6180 File Offset: 0x000A4380
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000A6190 File Offset: 0x000A4390
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

		// Token: 0x060023CF RID: 9167 RVA: 0x000A625C File Offset: 0x000A445C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroBiographyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015B9 RID: 5561
		private int _ID;

		// Token: 0x040015BA RID: 5562
		private string _Desc;

		// Token: 0x040015BB RID: 5563
		private readonly List<HeroBiographyCondition> _UnlockConditions = new List<HeroBiographyCondition>();

		// Token: 0x040015BC RID: 5564
		private string _Title;

		// Token: 0x040015BD RID: 5565
		private IExtension extensionObject;

		// Token: 0x040015BE RID: 5566
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015BF RID: 5567
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015C0 RID: 5568
		private LuaFunction m_ctor_hotfix;
	}
}
