function [img, width, height] = ReorderImage(img)
    % assume image to be HxWxC (with C: BGR)
    height = size(img, 1);
    width = size(img, 2);
    img = flip(img, 3);  % flip BGR to RGB
    img(:,:,4) = 255 * ones(height, width);  % add (opaque) alpha channel
    img = permute(img, [2 1 3]);  % reorder to WxHxC
    % return flattened array
    % with RGBA,RGBA,RGBA (row-first)
    img = reshape(shiftdim(img, 2), 1, []);
end