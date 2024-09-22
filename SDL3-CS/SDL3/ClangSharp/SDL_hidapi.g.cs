/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_hid_device
    {
    }

    public enum SDL_hid_bus_type
    {
        SDL_HID_API_BUS_UNKNOWN = 0x00,
        SDL_HID_API_BUS_USB = 0x01,
        SDL_HID_API_BUS_BLUETOOTH = 0x02,
        SDL_HID_API_BUS_I2C = 0x03,
        SDL_HID_API_BUS_SPI = 0x04,
    }

    public unsafe partial struct SDL_hid_device_info
    {
        [NativeTypeName("char *")]
        public byte* path;

        [NativeTypeName("unsigned short")]
        public ushort vendor_id;

        [NativeTypeName("unsigned short")]
        public ushort product_id;

        [NativeTypeName("wchar_t *")]
        public IntPtr serial_number;

        [NativeTypeName("unsigned short")]
        public ushort release_number;

        [NativeTypeName("wchar_t *")]
        public IntPtr manufacturer_string;

        [NativeTypeName("wchar_t *")]
        public IntPtr product_string;

        [NativeTypeName("unsigned short")]
        public ushort usage_page;

        [NativeTypeName("unsigned short")]
        public ushort usage;

        public int interface_number;

        public int interface_class;

        public int interface_subclass;

        public int interface_protocol;

        public SDL_hid_bus_type bus_type;

        [NativeTypeName("struct SDL_hid_device_info *")]
        public SDL_hid_device_info* next;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_init();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_exit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_hid_device_change_count();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device_info* SDL_hid_enumerate([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_hid_free_enumeration(SDL_hid_device_info* devs);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device* SDL_hid_open([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id, [NativeTypeName("const wchar_t *")] IntPtr serial_number);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device* SDL_hid_open_path([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_write(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_read_timeout(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length, int milliseconds);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_read(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_send_feature_report(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_feature_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_input_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_close(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_manufacturer_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] IntPtr @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_product_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] IntPtr @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_serial_number_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] IntPtr @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_indexed_string(SDL_hid_device* dev, int string_index, [NativeTypeName("wchar_t *")] IntPtr @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device_info* SDL_hid_get_device_info(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_report_descriptor(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* buf, [NativeTypeName("size_t")] nuint buf_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_hid_ble_scan([NativeTypeName("bool")] SDLBool active);
    }
}
