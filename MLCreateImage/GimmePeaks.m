function [img, width, height] = GimmePeaks(gridsize)
    f = figure('visible', 'off');
    [x, y, z] = peaks(gridsize);
    surf(x, y, z);
    frame = getframe(f);
    img = frame2im(frame);
    % imwrite(img, 'output.png');
    [img, width, height] = ReorderImage(img);
end
