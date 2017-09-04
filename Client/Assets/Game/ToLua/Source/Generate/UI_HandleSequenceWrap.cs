﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UI_HandleSequenceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UI.HandleSequence), typeof(UI.IHandle));
		L.RegFunction("SetTime", SetTime);
		L.RegFunction("Start", Start);
		L.RegFunction("OnUpdate", OnUpdate);
		L.RegFunction("OnEnd", OnEnd);
		L.RegFunction("OnReset", OnReset);
		L.RegFunction("New", _CreateUI_HandleSequence);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("IsDurationValid", get_IsDurationValid, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUI_HandleSequence(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UI.HandleSequence obj = new UI.HandleSequence();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UI.HandleSequence.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UI.HandleSequence obj = (UI.HandleSequence)ToLua.CheckObject(L, 1, typeof(UI.HandleSequence));
			UI.Handle arg0 = (UI.Handle)ToLua.CheckObject(L, 2, typeof(UI.Handle));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetTime(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Start(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UI.HandleSequence obj = (UI.HandleSequence)ToLua.CheckObject(L, 1, typeof(UI.HandleSequence));
			UI.Handle arg0 = (UI.Handle)ToLua.CheckObject(L, 2, typeof(UI.Handle));
			obj.Start(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UI.HandleSequence obj = (UI.HandleSequence)ToLua.CheckObject(L, 1, typeof(UI.HandleSequence));
			UI.Handle arg0 = (UI.Handle)ToLua.CheckObject(L, 2, typeof(UI.Handle));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.OnUpdate(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UI.HandleSequence obj = (UI.HandleSequence)ToLua.CheckObject(L, 1, typeof(UI.HandleSequence));
			UI.Handle arg0 = (UI.Handle)ToLua.CheckObject(L, 2, typeof(UI.Handle));
			obj.OnEnd(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UI.HandleSequence obj = (UI.HandleSequence)ToLua.CheckObject(L, 1, typeof(UI.HandleSequence));
			UI.Handle arg0 = (UI.Handle)ToLua.CheckObject(L, 2, typeof(UI.Handle));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.OnReset(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsDurationValid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UI.HandleSequence obj = (UI.HandleSequence)o;
			bool ret = obj.IsDurationValid;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsDurationValid on a nil value" : e.Message);
		}
	}
}

