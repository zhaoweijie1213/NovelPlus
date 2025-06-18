import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import { createVuetify } from 'vuetify';
import pinia from "./stores";
import 'vuetify/styles';

const vuetify = createVuetify();

createApp(App).use(router).use(pinia).use(vuetify).mount('#app');
