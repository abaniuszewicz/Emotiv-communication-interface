threshold = 0.1:0.1:1;

frown_s_base = 100;
frown_ns_base = 50;
frown_s_500 = [50 70 90 100 90 100 80 80 70 70];
frown_ns_500 = [30 20 20 10 0 0 0 0 0 0];
frown_s_1500 = [50 80 80 90 100 100 50 20 10 10];
frown_ns_1500 = [20 20 0 0 0 0 0 0 0 0];
frown_s_2500 = [50 30 10 0 0 0 0 0 0 0];
frown_ns_2500 = [0 0 0 0 0 0 0 0 0 0];

up_s_base = 90;
up_ns_base = 50;
up_s_500 = [100 100 100 100 90 80 60 40 0 0];
up_ns_500 = [100 100 100 90 90 90 70 30 0 0];
up_s_1500 = [100 100 80 60 10 0 0 0 0 0];
up_ns_1500 = [100 100 70 50 0 0 0 0 0 0];
up_s_2500 = [100 60 50 50 10 0 0 0 0 0];
up_ns_2500 = [100 60 60 40 0 0 0 0 0 0];



frown500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, frown_s_500, '-o');
plot(threshold, frown_ns_500, '--s');
plot(threshold, frown_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, frown_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas wykonania','Detekcja podczas braku wykonania', 'Location','best');

frown1500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, frown_s_1500, '-o');
plot(threshold, frown_ns_1500, '--s');
plot(threshold, frown_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, frown_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas wykonania','Detekcja podczas braku wykonania', 'Location','best');

frown2500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, frown_s_2500, '-o');
plot(threshold, frown_ns_2500, '--s');
plot(threshold, frown_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, frown_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas wykonania','Detekcja podczas braku wykonania', 'Location','best');

set(frown500, 'Units', 'Inches');
pos = get(frown500, 'Position');
set(frown500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(frown500, 'frown500', '-dpdf', '-r0');

set(frown1500, 'Units', 'Inches');
pos = get(frown1500, 'Position');
set(frown1500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(frown1500, 'frown1500', '-dpdf', '-r0');

set(frown2500, 'Units', 'Inches');
pos = get(frown2500, 'Position');
set(frown2500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(frown2500, 'frown2500', '-dpdf', '-r0');

% mental

up500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, up_s_500, '-o');
plot(threshold, up_ns_500, '--s');
plot(threshold, up_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, up_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia', 'Location','best');

up1500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, up_s_1500, '-o');
plot(threshold, up_ns_1500, '--s');
plot(threshold, up_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, up_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia', 'Location','best');

up2500 = figure;
hold on
xlim([0.1 1]); ylim([0 100])
xlabel('Threshold'); ylabel('Stosunek detekcji do iloœci prób [%]')
plot(threshold, up_s_2500, '-o');
plot(threshold, up_ns_2500, '--s');
plot(threshold, up_s_base * ones(size(threshold)), '-', 'LineWidth', 2.0);
set(gca,'ColorOrderIndex',3)
plot(threshold, up_ns_base * ones(size(threshold)), '--', 'LineWidth', 2.0);
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia', 'Location','best');

set(up500, 'Units', 'Inches');
pos = get(up500, 'Position');
set(up500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(up500, 'up500', '-dpdf', '-r0');

set(up1500, 'Units', 'Inches');
pos = get(up1500, 'Position');
set(up1500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(up1500, 'up1500', '-dpdf', '-r0');

set(up2500, 'Units', 'Inches');
pos = get(up2500, 'Position');
set(up2500, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(up2500, 'up2500', '-dpdf', '-r0');


