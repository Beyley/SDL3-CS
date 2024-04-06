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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL
{
    [Flags]
    public enum SDL_RendererFlags
    {
        SDL_RENDERER_PRESENTVSYNC = 0x00000004,
    }

    public unsafe partial struct SDL_RendererInfo
    {
        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("Uint32")]
        public uint flags;

        public int num_texture_formats;

        [NativeTypeName("SDL_PixelFormatEnum[16]")]
        public _texture_formats_e__FixedBuffer texture_formats;

        public int max_texture_width;

        public int max_texture_height;

        [InlineArray(16)]
        public partial struct _texture_formats_e__FixedBuffer
        {
            public SDL_PixelFormatEnum e0;
        }
    }

    public partial struct SDL_Vertex
    {
        public SDL_FPoint position;

        public SDL_FColor color;

        public SDL_FPoint tex_coord;
    }

    public enum SDL_TextureAccess
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }

    public enum SDL_RendererLogicalPresentation
    {
        SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE,
    }

    public partial struct SDL_Renderer
    {
    }

    public partial struct SDL_Texture
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumRenderDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* SDL_GetRenderDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CreateWindowAndRenderer(int width, int height, [NativeTypeName("SDL_WindowFlags")] uint window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_GetRenderer(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetRenderWindow(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRendererInfo(SDL_Renderer* renderer, SDL_RendererInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetRendererProperties(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormatEnum format, int access, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTextureWithProperties(SDL_Renderer* renderer, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetTextureProperties(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_GetRendererFromTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_QueryTexture(SDL_Texture* texture, SDL_PixelFormatEnum* format, int* access, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] IntPtr pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("void **")] IntPtr* pixels, int* pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode, SDL_ScaleMode* scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_RenderViewportSet(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_RenderClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderColorScale(SDL_Renderer* renderer, float scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderColorScale(SDL_Renderer* renderer, float* scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderPoint(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, [NativeTypeName("const double")] double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, [NativeTypeName("const SDL_FlipMode")] SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_Color *")] SDL_Color* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] IntPtr indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderGeometryRawFloat(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_FColor *")] SDL_FColor* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] IntPtr indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_FlushRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void*")]
        public static extern IntPtr SDL_GetRenderMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void*")]
        public static extern IntPtr SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint wait_stage_mask, [NativeTypeName("Sint64")] long wait_semaphore, [NativeTypeName("Sint64")] long signal_semaphore);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);

        [NativeTypeName("#define SDL_SOFTWARE_RENDERER \"software\"")]
        public static ReadOnlySpan<byte> SDL_SOFTWARE_RENDERER => "software"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_NAME_STRING \"name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_NAME_STRING => "name"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_WINDOW_POINTER \"window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_WINDOW_POINTER => "window"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_SURFACE_POINTER \"surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_SURFACE_POINTER => "surface"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER \"output_colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER => "output_colorspace"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_BOOLEAN \"present_vsync\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_BOOLEAN => "present_vsync"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER \"vulkan.instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER => "vulkan.instance"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER \"vulkan.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER => "vulkan.surface"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER \"vulkan.physical_device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER => "vulkan.physical_device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER \"vulkan.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER => "vulkan.device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"vulkan.graphics_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "vulkan.graphics_queue_family_index"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"vulkan.present_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "vulkan.present_queue_family_index"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_NAME_STRING \"SDL.renderer.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_NAME_STRING => "SDL.renderer.name"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_WINDOW_POINTER \"SDL.renderer.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_WINDOW_POINTER => "SDL.renderer.window"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_SURFACE_POINTER \"SDL.renderer.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_SURFACE_POINTER => "SDL.renderer.surface"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.output_colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER => "SDL.renderer.output_colorspace"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN \"SDL.renderer.HDR_enabled\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN => "SDL.renderer.HDR_enabled"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT \"SDL.renderer.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT => "SDL.renderer.SDR_white_point"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT \"SDL.renderer.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT => "SDL.renderer.HDR_headroom"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D9_DEVICE_POINTER \"SDL.renderer.d3d9.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D9_DEVICE_POINTER => "SDL.renderer.d3d9.device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_DEVICE_POINTER \"SDL.renderer.d3d11.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D11_DEVICE_POINTER => "SDL.renderer.d3d11.device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_DEVICE_POINTER \"SDL.renderer.d3d12.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D12_DEVICE_POINTER => "SDL.renderer.d3d12.device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER \"SDL.renderer.d3d12.command_queue\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER => "SDL.renderer.d3d12.command_queue"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER \"SDL.renderer.vulkan.instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER => "SDL.renderer.vulkan.instance"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER \"SDL.renderer.vulkan.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER => "SDL.renderer.vulkan.surface"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.vulkan.physical_device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER => "SDL.renderer.vulkan.physical_device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER \"SDL.renderer.vulkan.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER => "SDL.renderer.vulkan.device"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.graphics_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.graphics_queue_family_index"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.present_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.present_queue_family_index"u8;

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER \"SDL.renderer.vulkan.swapchain_image_count\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER => "SDL.renderer.vulkan.swapchain_image_count"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER \"colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER => "colorspace"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER \"format\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER => "format"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER \"access\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER => "access"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER \"width\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER => "width"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER \"height\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER => "height"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT \"SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT => "SDR_white_point"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT \"HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT => "HDR_headroom"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER \"d3d11.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER => "d3d11.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER \"d3d11.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER => "d3d11.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER \"d3d11.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER => "d3d11.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER \"d3d12.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER => "d3d12.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER \"d3d12.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER => "d3d12.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER \"d3d12.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER => "d3d12.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER \"metal.pixelbuffer\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER => "metal.pixelbuffer"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER \"opengl.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER => "opengl.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER \"opengl.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER => "opengl.texture_uv"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER \"opengl.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER => "opengl.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER \"opengl.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER => "opengl.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER \"opengles2.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER => "opengles2.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER \"opengles2.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER => "opengles2.texture_uv"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER \"opengles2.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER => "opengles2.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER \"opengles2.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER => "opengles2.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER \"vulkan.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER => "vulkan.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_COLORSPACE_NUMBER \"SDL.texture.colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_COLORSPACE_NUMBER => "SDL.texture.colorspace"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT \"SDL.texture.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT => "SDL.texture.SDR_white_point"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT \"SDL.texture.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT => "SDL.texture.HDR_headroom"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER \"SDL.texture.d3d11.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER => "SDL.texture.d3d11.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER \"SDL.texture.d3d11.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER => "SDL.texture.d3d11.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER \"SDL.texture.d3d11.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER => "SDL.texture.d3d11.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER \"SDL.texture.d3d12.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER => "SDL.texture.d3d12.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER \"SDL.texture.d3d12.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER => "SDL.texture.d3d12.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER \"SDL.texture.d3d12.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER => "SDL.texture.d3d12.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER \"SDL.texture.opengl.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER => "SDL.texture.opengl.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.opengl.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER => "SDL.texture.opengl.texture_uv"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.opengl.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER => "SDL.texture.opengl.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.opengl.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER => "SDL.texture.opengl.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER \"SDL.texture.opengl.target\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER => "SDL.texture.opengl.target"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT \"SDL.texture.opengl.tex_w\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT => "SDL.texture.opengl.tex_w"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT \"SDL.texture.opengl.tex_h\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT => "SDL.texture.opengl.tex_h"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.opengles2.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER => "SDL.texture.opengles2.texture"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.opengles2.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER => "SDL.texture.opengles2.texture_uv"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.opengles2.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER => "SDL.texture.opengles2.texture_u"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.opengles2.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER => "SDL.texture.opengles2.texture_v"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER \"SDL.texture.opengles2.target\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER => "SDL.texture.opengles2.target"u8;

        [NativeTypeName("#define SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER \"SDL.texture.vulkan.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER => "SDL.texture.vulkan.texture"u8;
    }
}
